Class PackageTypes : System.Management.Automation.IValidateSetValuesGenerator {
    [string[]] GetValidValues() {
        $PackageTypes = ,"zip"
        if ($global:IsMacOS -or $global:IsLinux) {
            $PackageTypes += "tar"
        }
        return [string[]] $PackageTypes
    }
}

function Get-Version {
    [OutputType([string])]
    param(
        [string] $BranchOrTagName = "latest"
    )

    Write-Verbose "Get-Version: Getting version."

    if ([string]::IsNullOrWhitespace($BranchOrTagName)) {
        $BranchOrTagName = "unknown"
    }
    # Get the version
    $version = "$BranchOrTagName"
    $version = $version.TrimStart('refs/tags/v')
    # Return the version
    return $version
}

function Get-FileName {
    [OutputType([string])]
    param(
        [ValidateNotNullOrEmpty()]
        [string] $FileNameTemplate = "msgraph-cli-{0}-{1}",

        [ValidateNotNullOrEmpty()]
        [string] $BranchOrTagName = "latest",

        [string] $RuntimeIdentifier = "unknown"
    )

    Write-Verbose "Get-FileName: Getting file name."

    if ([string]::IsNullOrWhitespace($RuntimeIdentifier)) {
        $RuntimeIdentifier = "unknown"
    }

    $version = Get-Version $BranchOrTagName
    return "$FileNameTemplate" -f "$RuntimeIdentifier","$version"
}

function Get-PackageName {
    [OutputType([string])]
    param(
        [ValidateNotNullOrEmpty()]
        [string] $FileName,

        [ValidateNotNullOrEmpty()]
        [string] $FileNameTemplate,

        [ValidateNotNullOrEmpty()]
        [string] $BranchOrTagName = "latest",

        [string] $RuntimeIdentifier = "unknown",

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none"
    )

    Write-Verbose "Get-PackageName: Getting package name."
    if ([string]::IsNullOrWhitespace($FileName) -and [string]::IsNullOrWhitespace($FileNameTemplate)) {
        throw "Either FileName or FileNameTemplate must be specified."
    }

    $ext = $PackageType
    if ($ext -eq "tar" -and (-not ($TarCompression -eq "none"))) {
        if ($TarCompression -eq "bzip") {
            $ext += ".bz2"
        } elseif ($TarCompression -eq "gzip") {
            $ext += ".gz"
        }
    }

    if ([string]::IsNullOrWhitespace($FileName)) {
        $FileName = Get-FileName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    }

    return "$FileName.$ext"
}

function Compress-Package {
    [cmdletbinding()]
    [OutputType([string])]
    param(
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputDir = ".",

        [Parameter(Mandatory)]
        [ValidateScript({
            (Resolve-Path -Path $_ | Measure-Object).Count -gt 0
        }, ErrorMessage="The path '{0}' is invalid. Ensure it's a directory, a comma-separated list or a wildcard that resolves to a list of files.")]
        [string[]] $Source,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $FileName,

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none"
    )

    Write-Verbose "Compress-Package: Compressing package '$FileName', '$PackageType', $TarCompression."

    if (($PackageType -eq "zip") -and ($TarCompression -ne "none")) {
        Write-Warning "Compress-Package: Tar compression only has an effect on the tar package type. The option will be ignored."
    }

    $OutputDir = Resolve-Path $OutputDir
    Write-Verbose "Compress-Package: Using the dir '$OutputDir'."

    $ext = $PackageType
    if ($ext -eq "tar" -and (-not ($TarCompression -eq "none"))) {
        if ($TarCompression -eq "bzip") {
            $ext += ".bz2"
        } elseif ($TarCompression -eq "gzip") {
            $ext += ".gz"
        }
    }

    $outputFileName = Get-PackageName -FileName $FileName -PackageType $PackageType -TarCompression $TarCompression
    $outputFile = Join-Path $OutputDir $outputFileName

    if (Test-Path $outputFile) {
        Write-Verbose "Compress-Package: Removing existing file $outputFile."
        Remove-Item $outputFile
    }

    Write-Verbose "$Source"

    if ($PackageType -eq "zip") {
        Compress-Archive -Path $Source -DestinationPath $outputFile
    } elseif ($PackageType -eq "tar") {
        if (Get-Command -Name tar -CommandType Application -ErrorAction Ignore) {
            $options = "-c"
            if ($TarCompression -eq "bzip") {
                $options += "j"
            } elseif ($TarCompression -eq "gzip") {
                $options += "z"
            }

            if (($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) -or ($PSCmdlet.GetVariableValue('VerbosePreference'))) {
                # Use the verbose mode '-v' if '-Verbose' is specified
                $options += "v"
            }
            $options += "f"

            # Match PowerShell Compress-Archive behavior
            # Add the result of Get-Item -Name
            $_args = $Source | ForEach-Object {
                $items = Get-Item $_
                # Get the working dir
                $dir = $items | Select-Object -First 1 | ForEach-Object {[System.IO.Path]::GetDirectoryName("$_")}
                # Get the file list
                $_files = $items | ForEach-Object -Begin $null -Process {[System.IO.Path]::GetFileName("$_")},{ Write-Verbose "$($_.FullName)"} -End $null

                Write-Verbose "Compress-Package: Adding files in dir '$dir':`n  $([string]::Join("`n  ", $_files))"
                "-C $dir $([string]::Join(" ", $_files))"
            }

            $joined = $([string]::Join(" ", $_args))
            # Set-PSDebug -Trace 2
            $cmd = "tar $options $outputFile $joined"
            Invoke-Expression $cmd | Write-Verbose
        } else {
            throw "Failed to create the package. Application 'tar' cannot be found."
        }
    }

    if (Test-Path -Path $outputFile) {
        Write-Verbose "Archive created at $outputFile"
        return "$outputFile"
    } else {
        throw "Failed to create archive $outputFile"
    }
}

function Expand-Package {
    [cmdletbinding()]
    [OutputType([string])]
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputDir,

        [ValidateScript({
            Test-Path -Path $_ -PathType Container
        }, ErrorMessage="The work dir '{0}' is invalid. Check that it exists and is a directory.")]
        [string] $SourceDir,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $FileName,

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none"
    )

    Write-Verbose "Expand-Package: Expanding package '$FileName', '$PackageType', $TarCompression."

    if (($PackageType -eq "zip") -and ($TarCompression -ne "none")) {
        Write-Warning "Expand-Package: Tar compression only has an effect on the tar package type. The option will be ignored."
    }

    if ([string]::IsNullOrWhitespace($SourceDir)) {
        $SourceDir = Resolve-Path $SourceDir
        Write-Warning "Expand-Package: The SourceDir parameter was not provided. Using the current directory '$SourceDir'."
    }

    $ext = $PackageType
    # Don't set extension name. Use TarCompression to determine compression program
    if ($ext -eq "tar") {
        $ext += "*"
    }

    $pattern = "$FileName.$ext"
    $candidates = Resolve-Path $(Join-Path $SourceDir $pattern) | Select-Object -ExpandProperty Path

    if (($candidates | Measure-Object).Count -le 0) {
        throw "There are no files in '$SourceDir' matching pattern '$pattern'."
    } elseif (($candidates | Measure-Object).Count -gt 1) {
        $names = $candidates | ForEach-Object { [io.path]::GetFileName($_) }
        $closestMatch = $names[0]

        if ($PackageType -eq "tar") {
            # Try to find a matching tar file
            $_exp = ""
            if ($TarCompression -eq "bzip") {
                $_exp = ".+\.[bt]b?z[2]?"
            } elseif ($TarCompression -eq "gzip") {
                $_exp = ".+\.(?:g|t[ga])z"
            }
            foreach ($_name in $names) {
                if ($_name -match $_exp) {
                    $closestMatch = $_name
                    break
                }
            }
        }
        Write-Warning "Expand-Package: Multiple files found matching '$pattern'.`n  $([string]::Join("`n  ", $names))`nUsing the closest match '$closestMatch'."
        $inputFile = $closestMatch
    } else {
        Write-Verbose "Expand-Package: Archive file $candidates found."
        # Only 1 match
        $inputFile = $candidates
    }

    if ($PackageType -eq "zip") {
        Write-Verbose "Expand-Package: Expanding zip archive '$inputFile'"
        Expand-Archive -Path $inputFile -DestinationPath $OutputDir
    } elseif ($PackageType -eq "tar") {
        if (Get-Command -Name tar -CommandType Application -ErrorAction Ignore) {
            if (-not (Test-Path -Path $OutputDir)) {
                # Suppress command output to avoid poisoning this function's result
                $item = New-Item $OutputDir -ItemType Directory
                Write-Verbose "Expand-Package: Output directory '$item' did not exist. It has been created."
            }

            Write-Verbose "Expand-Package: Expanding tar archive '$inputFile'"
            $options = "-x"
            if ($TarCompression -eq "bzip") {
                $options += "j"
            } elseif ($TarCompression -eq "gzip") {
                $options += "z"
            }

            if (($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) -or ($PSCmdlet.GetVariableValue('VerbosePreference'))) {
                # Use the verbose mode '-v' if '-Verbose' is specified
                $options += "v"
            }
            $options += "f"

            try {
                Push-Location -Path $OutputDir
                $cmd = "tar $options $inputFile"
                Invoke-Expression $cmd | Write-Verbose
            } finally {
                Pop-Location
            }
        } else {
            throw "Failed to extract the package. Application 'tar' cannot be found."
        }
    }

    if ((Test-Path -Path $OutputDir -PathType Container) -and ((Get-ChildItem $OutputDir) | Measure-Object).Count -gt 0) {
        Write-Verbose "Expand-Package: Archive '$inputFile' extracted to $OutputDir"
        return $OutputDir
    } else {
        throw "Failed to extract archive $inputFile"
    }
}

function Compress-BuildOutput {
    [OutputType([string])]
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputDir,

        [Parameter(Mandatory)]
        [ValidateScript({
            (Resolve-Path -Path $_ | Measure-Object).Count -gt 0
        }, ErrorMessage="The path '{0}' is invalid.")]
        [string[]] $Source,

        [string] $FileNameTemplate = "msgraph-cli-{0}-{1}",

        [string] $BranchOrTagName = "latest",

        [string] $RuntimeIdentifier = "unknown",

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none",

        [switch] $Cleanup
    )

    Write-Verbose "Compress-BuildOutput: Compressing build output. '$FileName', '$PackageType', $TarCompression."

    if (-not (Test-Path -Path $OutputDir)) {
        # Suppress command output to avoid poisoning this function's result
        $item = New-Item $OutputDir -ItemType Directory
        Write-Verbose "Compress-BuildOutput: Output directory '$item' did not exist. It has been created."
    }

    $archiveName = Get-FileName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $archivePath = Join-Path -Path $OutputDir -ChildPath $archiveName

    $package = Compress-Package -OutputDir $OutputDir -Source $Source -FileName $archiveName -PackageType $PackageType -TarCompression $TarCompression
    Write-Verbose "Compress-BuildOutput: Package $package created."

    if ($Cleanup) {
        foreach ($path in $Source) {
            Write-Verbose "Compress-BuildOutput: Cleaning up $path"
            Remove-Item $path -Force
        }
    }

    return "$package"
}

function Expand-EsrpArtifacts {
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            Test-Path $_ -PathType Container
        }, ErrorMessage="Source dir '{0}' is not a valid directory")]
        [string] $SourceDir,

        [string] $OutputDir,

        [string] $FileNameTemplate = "msgraph-cli-{0}-{1}",

        [string] $BranchOrTagName = "latest",

        [string] $RuntimeIdentifier = "unknown",

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none",

        [switch] $Cleanup
    )

    Write-Verbose "Expand-EsrpArtifacts: Expanding build artifact for ESRP."

    $archiveName = Get-FileName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier

    Expand-Package -OutputDir $OutputDir -SourceDir $SourceDir -FileName $archiveName -PackageType $PackageType -TarCompression $TarCompression

    if ($Cleanup) {
        # -Force so there's no confirmation
        # -Recurse so the child items warning isn't shown
        Write-Verbose "Expand-EsrpArtifacts: Cleaning up $SourceDir"
        Remove-Item $SourceDir -Recurse -Force
    }
}

function Move-NonExecutableItems {
    param(
        [Parameter(Mandatory)]
        [string] $SourcePath,

        [string[]] $ExecutableItemNames
    )

    $parentDir = Split-Path -Path $SourcePath -Parent -Resolve
    $backupDir = Join-Path -Path $parentDir -ChildPath backup

    if (-not (Test-Path -Path $backupDir/*)) {
        New-Item $backupDir -ItemType Directory > $null
    } else {
        throw "The directory $backupDir already exists and is not empty."
    }

    Move-Item -Path $SourcePath/* -Exclude $ExecutableItemNames -Destination $backupDir
}

function Compress-SignedFiles {
    [OutputType([string])]
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            ((Test-Path $_ -PathType Container) -and ((Get-ChildItem $_ | Measure-Object).Count -gt 0))
        }, ErrorMessage="Source dir '{0}' is invalid. Check that it is a non-empty directory.")]
        [string] $SourceDir,

        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $ReportDir,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputDir,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputFileName,

        [ValidateSet([PackageTypes])]
        [string] $PackageType = "zip",

        [ValidateSet("none", "bzip", "gzip")]
        [string] $TarCompression = "none",

        [switch] $Cleanup
    )

    Write-Verbose "Compress-SignedFiles: '$OutputFileName', '$PackageType', $TarCompression."

    if ((Get-Item "$SourceDir/*.md" | Measure-Object).Count -gt 0) {
        if (-not (Test-Path -Path $ReportDir)) {
            $item = New-Item $ReportDir -ItemType Directory
            Write-Verbose "Compress-SignedFiles: Output directory '$item' did not exist. It has been created."
        }

        Write-Verbose "Compress-SignedFiles: Moving signing report to $ReportDir"
        Move-Item -Path "$SourceDir/*.md" -Destination $ReportDir/
    } else {
        Write-Verbose "Pattern '$SourceDir/*.md' didn't match any files."
    }

    $parentDir = Split-Path -Path $SourceDir -Parent -Resolve
    $backupDir = Join-Path -Path $parentDir -ChildPath backup

    if ((Test-Path $backupDir -PathType Container) -and ((Get-ChildItem $backupDir | Measure-Object).Count -gt 0)) {
        $files = [string]::Join("`n  ", $(Get-Item "$backupDir/*" | Select-Object -ExpandProperty Name))
        Write-Verbose "Compress-SignedFiles: Moving the following files from $backupDir to archive staging location:`n  $files"
        Move-Item -Path "$backupDir/*" -Destination "$SourceDir"
    } else {
        Write-Verbose "The backup dir '$backupDir' has no files."
    }

    Write-Verbose "Compress-SignedFiles: Compressing '$SourceDir/*'"
    $package = Compress-Package -OutputDir $OutputDir -Source "$SourceDir/*" -FileName $OutputFileName -PackageType $PackageType -TarCompression $TarCompression
    Write-Verbose "Compress-SignedFiles: Package $package created."

    if ($Cleanup) {
        Write-Verbose "Compress-SignedFiles: Cleaning up $SourceDir and $backupDir"
        Remove-Item "$SourceDir" -Recurse -Force
        Remove-Item "$backupDir" -Recurse -Force
    }

    return "$package"
}

function Set-UnixPermissions {
    [cmdletbinding()]
    param(
        [Parameter(Mandatory)]
        [ValidatePattern("^(?:[ugoa]?(?:[-+=],?(?:[rwxXst]*|[ugo]),?)+(?<!,)|[-+=]?[0-7]{1,4})$", ErrorMessage="{0} is not a valid chmod mode")]
        [string] $Mode,

        [Parameter(Mandatory)]
        [ValidateScript({Test-Path $_})]
        [string] $Path
    )

    Write-Verbose "Set-UnixPermissions: Setting permissions."
    if (-not $IsLinux -and -not $IsMacOS) {
        throw "Unix permissions are only supported on Linux or MacOS."
    }

    if ($True -or {Get-Command -Name chmod -CommandType Application -ErrorAction Ignore}) {
        $options = ""
        if ($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) {
            # Use the verbose mode '-v' if '-Verbose' is specified
            $options += "v"
        }

        $cmd = "chmod $options $Mode $Path"
        Write-Verbose "Set-UnixPermissions: Running '$cmd'"
        Invoke-Expression $cmd | Write-Verbose
    } else {
        throw "Failed to set permissions. Application 'chmod' could not be found."
    }
}

function Update-SignedArchive {
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            Test-Path $_
        }, ErrorMessage="The input archive {0} does not exist.")]
        [string] $InputFile,

        [Parameter(Mandatory)]
        [string] $ReportDir,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputDir,

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string] $OutputFileName,

        [string[]] $ExeNames,

        [switch] $Cleanup
    )

    $extractOutput = Split-Path -Path $InputFile -Parent

    Write-Verbose "Update-SignedArchive: Extracting '$InputFile' to '$extractOutput'"

    Expand-Archive -Path "$InputFile" -DestinationPath "$extractOutput"

    foreach ($exe in $ExeNames) {
        $executableFile = Join-Path $extractOutput $exe
        Set-UnixPermissions "u+x" $(Join-Path $extractOutput $exe)
    }

    Write-Verbose "Update-SignedArchive: Extracted '$InputFile' removing it."
    Remove-Item -Path "$InputFile" -Force

    Compress-SignedFiles -SourceDir $extractOutput -ReportDir $ReportDir -OutputDir $OutputDir -OutputFileName $OutputFileName -PackageType "tar" -TarCompression "gzip" -Cleanup:$Cleanup
}
