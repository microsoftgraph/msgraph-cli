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
        Write-Output "Source dir is empty."
        return
    }

    if (-Not (Test-Path -Path $OutputDir)) {
        New-Item $OutputDir -ItemType Directory
    }

    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $OutputDir -ChildPath $zipName

    Compress-Archive -Path $SourceDir/* -DestinationPath $zipPath -Force

    if ($Cleanup) {
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
        Remove-Item $SourceDir -Recurse -Force
    }
}

function Move-NonExecutableItems {
    param(
        [Parameter(Mandatory)]
        [string]
        $SourcePath,
        [Parameter(Mandatory)]
        [string]
        $DestinationPath,
        [string[]]
        $ExecutableItemNames
    )

    if (-Not (Test-Path -Path $DestinationPath)) {
        New-Item $DestinationPath -ItemType Directory
    }

    Move-Item -Path $SourcePath/* -Exclude $ExecutableItemNames -Destination $DestinationPath
}

function Compress-SignedFiles {
    param(
        [Parameter(Mandatory)]
        [string]
        $SourceDir,
        [string]
        $ReportDir,
        [string]
        $ExtraSourceDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile,
        [switch]
        $Cleanup
    )

    if (-Not (Test-Path -Path "$SourceDir/*")) {
        Write-Output "Source dir is empty."
        return
    }

    if (-Not $OutputFile) {
        Write-Output "Output zip file path not provided."
        return
    }

    if ($ReportDir -and (Test-Path -Path $ReportDir)) {
        Move-Item -Path "$SourceDir/*.md" -Destination $ReportDir
    }
    
    if ($ExtraSourceDir -and (Test-Path -Path "$ExtraSourceDir/*")) {
        Move-Item -Path "$ExtraSourceDir/*" -Destination "$SourceDir"
    }

    Compress-Archive -Path "$SourceDir/*" -DestinationPath $OutputFile -Force

    if ($Cleanup) {
        Remove-Item "$SourceDir" -Recurse -Force
        Remove-Item "$ExtraSourceDir" -Recurse -Force
    }
}

function Update-SignedArchive {
    param(
        [Parameter(Mandatory)]
        [string]
        $InputFile,
        [Parameter(Mandatory)]
        [string]
        $TempDir,
        [string]
        $ReportDir,
        [string]
        $ExtraSourceDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile,
        [switch]
        $Cleanup
    )

    if (-Not (Test-Path -Path "$InputFile")) {
        Write-Output "Input zip file does not exist."
        return
    }

    if (-Not $OutputFile) {
        Write-Output "Output zip file path not provided."
        return
    }

    if (-Not (Test-Path -Path "$TempDir")) {
        Write-Output "Temp dir is empty."
        return
    }

    Expand-Archive -Path "$InputFile" -DestinationPath "$TempDir"

    if ($ReportDir -and (Test-Path -Path $ReportDir)) {
        Move-Item -Path "$TempDir/*.md" -Destination $ReportDir
    }

    Compress-SignedFiles -SourceDir $TempDir -ExtraSourceDir $ExtraSourceDir -OutputFile $OutputFile -Cleanup $Cleanup
}
