function Get-Version {
    param(
        [string]
        $BranchOrTagName = "latest"
    )
    # Get the version
    $version = "$BranchOrTagName"
    $version = $version.TrimStart('refs/tags/v')
    # Return the version
    return $version
}

function Get-ZipName {
    param(
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}.zip",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown"
    )
    $version = Get-Version $BranchOrTagName 
    return "$FileNameTemplate" -f "$RuntimeIdentifier","$version"
}

function Compress-BuildOutput {
    param(
        [Parameter(Mandatory)]
        [string]
        $OutputDir,
        [Parameter(Mandatory)]
        [string]
        $SourceDir,
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}.zip",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown",
        [switch]
        $Cleanup
    )

    if (-Not (Test-Path -Path $SourceDir/*)) {
        Write-Error "Source dir is empty."
        return
    }

    if (-Not (Test-Path -Path $OutputDir)) {
        New-Item $OutputDir -ItemType Directory
    }

    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $OutputDir -ChildPath $zipName

    Compress-Archive -Path $SourceDir/* -DestinationPath $zipPath -Force

    if ($Cleanup) {
        Write-Information "Cleaning up $SourceDir"
        Remove-Item $SourceDir -Recurse -Force
    }
}

function Expand-EsrpArtifacts {
    param(
        [Parameter(Mandatory)]
        [string]
        $SourceDir,
        [string]
        $OutputDir,
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}.zip",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown",
        [switch]
        $Cleanup
    )
    # Get the archive name
    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $SourceDir -ChildPath $zipName

    Expand-Archive -Path $zipPath -DestinationPath $OutputDir

    if ($Cleanup) {
        # -Force so there's no confirmation
        # -Recurse so the child items warning isn't shown
        Write-Information "Cleaning up $SourceDir"
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

    $parentDir = Split-Path -Path $SourcePath -Parent
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
        [string]
        $SourceDir,
        [string]
        $ReportDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile,
        [switch]
        $Cleanup
    )

    if (-Not (Test-Path -Path "$SourceDir/*")) {
        Write-Error "Source dir is invalid."
        return
    }

    if (-Not $OutputFile) {
        Write-Error "Output zip file path not provided."
        return
    }

    if ($ReportDir -and (Test-Path -Path "$ReportDir/*.md")) {
        Write-Information "Moving signing report to $ReportDir"
        Move-Item -Path "$SourceDir/*.md" -Destination $ReportDir
    }
    
    $parentDir = Split-Path -Path $SourceDir -Parent
    $backupDir = Join-Path -Path $parentDir -ChildPath backup

    if ($backupDir -and (Test-Path -Path "$backupDir/*")) {
        Write-Information "Moving the following files to archive source location"
        Get-ChildItem -Path "$backupDir/*" -Recurse -Force -ErrorAction SilentlyContinue | Select-Object FullName
        Move-Item -Path "$backupDir/*" -Destination "$SourceDir"
    }

    Compress-Archive -Path "$SourceDir/*" -DestinationPath $OutputFile -Force

    if ($Cleanup) {
        Write-Information "Cleaning up $SourceDir and $backupDir"
        Remove-Item "$SourceDir" -Recurse -Force
        Remove-Item "$backupDir" -Recurse -Force
    }
}

function Update-SignedArchive {
    param(
        [Parameter(Mandatory)]
        [string]
        $InputFile,
        [Parameter(Mandatory)]
        [string]
        $ReportDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile,
        [switch]
        $Cleanup
    )

    if (-Not (Test-Path -Path "$InputFile" -PathType Leaf)) {
        Write-Error "Input zip file does not exist."
        return
    }

    if (-Not $OutputFile) {
        Write-Error "Output zip file path not provided."
        return
    }

    $parentDir = Split-Path -Path $InputFile -Parent
    $extractOutput = Join-Path -Path $parentDir -ChildPath tmp

    Expand-Archive -Path "$InputFile" -DestinationPath "$extractOutput"

    Compress-SignedFiles -SourceDir $extractOutput -ReportDir $ReportDir -OutputFile $OutputFile -Cleanup:$Cleanup
}
