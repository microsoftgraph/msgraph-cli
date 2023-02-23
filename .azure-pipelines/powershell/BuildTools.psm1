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
    param(
        [string]
        $BranchOrTagName = "latest"
    )

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
    param(
        [ValidateNotNullOrEmpty()]
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}",
        [ValidateNotNullOrEmpty()]
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown"
    )
    if ([string]::IsNullOrWhitespace($RuntimeIdentifier)) {
        $RuntimeIdentifier = "unknown"
    }

    $version = Get-Version $BranchOrTagName
    return "$FileNameTemplate" -f "$RuntimeIdentifier","$version"
}

function Get-PackageName {
    param(
        [ValidateNotNullOrEmpty()]
        [string]
        $FileName,
        [ValidateNotNullOrEmpty()]
        [string]
        $FileNameTemplate,
        [ValidateNotNullOrEmpty()]
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown",
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none"
    )

    if ([string]::IsNullOrWhitespace($FileName) -and [string]::IsNullOrWhitespace($FileNameTemplate)) {
        throw "Either FileName or FileNameTemplate must be specified."
    }

    $version = Get-Version $BranchOrTagName

    $ext = $PackageType
    if ($ext -eq "tar" -and (-not ($TarCompression -eq "none"))) {
        if ($TarCompression -eq "gzip") {
            $ext += ".gz"
        }
        if ($TarCompression -eq "gzip") {
            $ext += ".bz2"
        }
    }

    if ([string]::IsNullOrWhitespace($FileName)) {
        $FileName = Get-FileName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    }

    return "$FileName.$ext"
}

function Compress-Package {
    param(
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputDir = ".",
        [Parameter(Mandatory)]
        [ValidateScript({
            (Resolve-Path -Path $_ | Measure-Object).Count -gt 0
        }, ErrorMessage="The path '{0}' is invalid. Ensure it's a directory, a comma-separated list or a wildcard that resolves to a list of files.")]
        [string[]]
        $Source,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $FileName,
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none"
    )

    if (($PackageType -eq "zip") -and ($TarCompression -ne "none")) {
        Write-Warning "Tar compression only has an effect on the tar package type. The option will be ignored."
    }

    $OutputDir = Resolve-Path $OutputDir
    Write-Verbose "Using the current dir '$OutputDir'."

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
        Remove-Item $outputFile
    }

    if ($PackageType -eq "zip") {
        Compress-Archive -Path $Source -DestinationPath $outputFile
    } else if ($PackageType -eq "tar") {
        if (Get-Command -Name tar -CommandType Application -ErrorAction Ignore) {
            $options = "-c"
            if ($TarCompression -eq "bzip") {
                $options += "j"
            } elseif ($TarCompression -eq "gzip") {
                $options += "z"
            }

            if ($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) {
                # Use the verbose mode '-v' if '-Verbose' is specified
                $options += "v"
            }
            $options += "f"

            # Match PowerShell Compress-Archive behavior
            $_setRecursion = $False
            $Source = $Source | ForEach-Object {
                if ($_.EndsWith("*.*") -and (-not $_setRecursion)) {
                    $options = "--no-recursion $options"
                    $_setRecursion = $True
                }

                $_.Replace(".*", "")
            }

            tar $options $outputFile $([string]::Join(" ", $Source))
        } else {
            throw "Failed to create the package. Application 'tar' cannot be found."
        }
    }

    if (Test-Path -Path $outputFile) {
        Write-Verbose "Archive created at $outputFile"
        return $outputFile
    } else {
        throw "Failed to create archive $outputFile"
    }
}

function Expand-Package {
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputDir,
        [ValidateScript({
            Test-Path -Path $_ -PathType Container
        }, ErrorMessage="The work dir '{0}' is invalid. Check that it exists and is a directory.")]
        [string]
        $SourceDir,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $FileName,
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none",
    )

    if (($PackageType -eq "zip") -and ($TarCompression -ne "none")) {
        Write-Warning "Tar compression only has an effect on the tar package type. The option will be ignored."
    }

    if ([string]::IsNullOrWhitespace($SourceDir)) {
        $SourceDir = Resolve-Path $SourceDir
        Write-Warning "The SourceDir parameter was not provided. Using the current directory '$SourceDir'."
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
        Write-Warning "Multiple files found matching '$pattern'.`n  $([string]::Join("`n  ", $names))`nUsing the closest match '$closestMatch'."
        $inputFile = $closestMatch
    } else {
        # Only 1 match
        $inputFile = $candidates
    }

    if ($PackageType -eq "zip") {
        Expand-Archive -Path $inputFile -DestinationPath $OutputDir
    } else if ($PackageType -eq "tar") {
        if (Get-Command -Name tar -CommandType Application -ErrorAction Ignore) {
            $options = "-x"
            if ($TarCompression -eq "bzip") {
                $options += "j"
            } elseif ($TarCompression -eq "gzip") {
                $options += "z"
            }

            if ($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) {
                # Use the verbose mode '-v' if '-Verbose' is specified
                $options += "v"
            }
            $options += "f"

            try {
                Push-Location -Path $OutputDir
                tar $options $inputFile
            } finally {
                Pop-Location
            }
        } else {
            throw "Failed to extract the package. Application 'tar' cannot be found."
        }
    }

    if ((Test-Path -Path $OutputFile -PathType Container) -and ((Get-ChildItem $OutputDir) | Measure-Object).Count -gt 0) {
        Write-Verbose "Archive '$inputFile' extracted to $OutputDir"
        return $OutputDir
    } else {
        throw "Failed to extract archive $inputFile"
    }
}

function Compress-BuildOutput {
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputDir,
        [Parameter(Mandatory)]
        [ValidateScript({
            (Resolve-Path -Path $_ | Measure-Object).Count -gt 0
        }, ErrorMessage="The path '{0}' is invalid.")]
        [string[]]
        $Source,
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown",
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none",
        [switch]
        $Cleanup
    )
    if (-Not (Test-Path -Path $OutputDir)) {
        New-Item $OutputDir -ItemType Directory
    }

    $archiveName = Get-PackageName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier -PackageType $PackageType -TarCompression $TarCompression
    $archivePath = Join-Path -Path $OutputDir -ChildPath $archiveName

    $package = Compress-Package -OutputDir $OutputDir -Source $Source -FileName $archiveName -PackageType "zip"

    if ($Cleanup) {
        Write-Verbose "Cleaning up $Source"
        Remove-Item $Source -Force
    }

    return $archivePath
}

function Expand-EsrpArtifacts {
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            Test-Path $_ -PathType Container
        }, ErrorMessage="Source dir '{0}' is not a valid directory")]
        [string]
        $SourceDir,
        [string]
        $OutputDir,
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown",
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none",
        [switch]
        $Cleanup
    )

    $archiveName = Get-PackageName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier -PackageType $PackageType -TarCompression $TarCompression

    Expand-Package -OutputDir $OutputDir -SourceDir $SourceDir -FileName $archiveName -PackageType $PackageType -TarCompression $TarCompression

    if ($Cleanup) {
        # -Force so there's no confirmation
        # -Recurse so the child items warning isn't shown
        Write-Verbose "Cleaning up $SourceDir"
        Remove-Item $SourceDir -Recurse -Force
    }
}

function Move-NonExecutableItems {
    param(
        [Parameter(Mandatory)]
        [string]
        $SourcePath,
        [string[]]
        $ExecutableItemNames
    )

    $parentDir = Split-Path -Path $SourcePath -Parent -Resolve
    $backupDir = Join-Path -Path $parentDir -ChildPath backup

    if (-Not (Test-Path -Path $backupDir/*)) {
        New-Item $backupDir -ItemType Directory
    } else {
        Write-Error "The directory $backupDir already exists and is not empty."
        return
    }

    Move-Item -Path $SourcePath/* -Exclude $ExecutableItemNames -Destination $backupDir
}

function Compress-SignedFiles {
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            ((Test-Path $_ -PathType Container) -and ((Get-ChildItem $_ | Measure-Object).Count -gt 0))
        }, ErrorMessage="Source dir '{0}' is invalid. Check that it is a non-empty directory.")]
        [string]
        $SourceDir,
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $ReportDir,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputDir,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputFileName,
        [ValidateSet([PackageTypes])]
        [string]
        $PackageType = "zip",
        [ValidateSet("none", "bzip", "gzip")]
        [string]
        $TarCompression = "none"
        [switch]
        $Cleanup
    )

    if ($ReportDir -and (Test-Path -Path "$SourceDir/*.md")) {
        if (-Not (Test-Path -Path $ReportDir)) {
            New-Item $ReportDir -ItemType Directory
        }

        Write-Verbose "Moving signing report to $ReportDir"
        Move-Item -Path "$SourceDir/*.md" -Destination $ReportDir/
    }

    $parentDir = Split-Path -Path $SourceDir -Parent -Resolve
    $backupDir = Join-Path -Path $parentDir -ChildPath backup

    if ($backupDir -and (Test-Path -Path "$backupDir/*")) {
        $files = [string]::Join("`n  ", $(Get-Item "$backupDir/*" | Select-Object Name))
        Write-Verbose "Moving the following files from $backupDir to archive staging location:\n  $files"
        Move-Item -Path "$backupDir/*" -Destination "$SourceDir"
    }

    if ($Cleanup) {
        Write-Verbose "Cleaning up $SourceDir and $backupDir"
        Remove-Item "$SourceDir" -Recurse -Force
        Remove-Item "$backupDir" -Recurse -Force
    }
}

function Set-UnixPermissions {
    param(
        [Parameter(Mandatory)]
        [ValidatePattern("^(?:[ugoa]?(?:[-+=],?(?:[rwxXst]*|[ugo]),?)+(?<!,)|[-+=]?[0-7]{1,4})$", ErrorMessage="{0} is not a valid chmod mode")]
        [string]
        $Mode,
        [Parameter(Mandatory)]
        [ValidateScript({Test-Path $_})]
        [string]
        $Path
    )

    if (-not $IsLinux -and -not $IsMacOS) {
        throw "Unix permissions are only supported on Linux or MacOS."
    }

    if ($True -or {Get-Command -Name chmod -CommandType Application -ErrorAction Ignore}) {
        $options = ""
        if ($PSBoundParameters.ContainsKey('Verbose') -and $PSBoundParameters['Verbose'].IsPresent) {
            # Use the verbose mode '-v' if '-Verbose' is specified
            $options += "v"
        }

        chmod $options $Mode $Path
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
        [string]
        $InputFile,
        [Parameter(Mandatory)]
        [string]
        $ReportDir,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputDir,
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [ValidateScript({Test-Path $_ -IsValid})]
        [string]
        $OutputFileName,
        [string[]]
        $ExeNames,
        [switch]
        $Cleanup
    )

    $extractOutput = Split-Path -Path $InputFile -Parent

    Expand-Archive -Path "$InputFile" -DestinationPath "$extractOutput"

    foreach ($exe in $ExeNames) {
        $executableFile = Join-Path $extractOutput $exe
        Set-UnixPermissions "u+x" $exe
    }

    Remove-Item -Path "$InputFile" -Force

    Compress-SignedFiles -SourceDir $extractOutput -ReportDir $ReportDir -OutputDir $OutputDir -OutputFileName $OutputFileName -PackageType "tar" -TarCompression "gzip" -Cleanup:$Cleanup
}
