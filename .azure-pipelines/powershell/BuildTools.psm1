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
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}.zip",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown"
    )

    if (-Not (Test-Path -Path $OutputDir)) {
        New-Item $OutputDir -ItemType Directory
    }

    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $OutputDir -ChildPath $FileName

    Compress-Archive -Path $OutputDir/* -DestinationPath $zipPath
    Remove-Item $OutputDir/*
}

function Expand-EsrpArtifacts {
    param(
        [Parameter(Mandatory)]
        [string]
        $ArtifactsDir,
        [string]
        $OutputDir,
        [string]
        $FileNameTemplate = "msgraph-cli-{0}-{1}.zip",
        [string]
        $BranchOrTagName = "latest",
        [string]
        $RuntimeIdentifier = "unknown"
    )
    # Get the archive name
    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $ArtifactsDir -ChildPath $zipName

    Expand-Archive -Path $zipPath -DestinationPath $OutputDir
    # -Force so there's no confirmation
    # -Recurse so the child items warning isn't shown
    Remove-Item $ArtifactsDir -Recurse -Force
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
        $ArtifactsDir,
        [string]
        $ReportDir,
        [string]
        $ExtraArtifactsDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile
    )

    if (-Not (Test-Path -Path "$ArtifactsDir/*")) {
        return
    }

    if (-Not ($OutputFile -and (Test-Path -Path "$OutputFile"))) {
        return
    }

    if ($ReportDir -and (Test-Path -Path $ReportDir)) {
        Move-Item -Path "$ArtifactsDir/*.md" -Destination $ReportDir
    }
    
    if ($ExtraArtifactsDir -and (Test-Path -Path "$ExtraArtifactsDir/*")) {
        Move-Item -Path "$ExtraArtifactsDir/*" -Destination "$ArtifactsDir"
    }

    Compress-Archive -Path "$ArtifactsDir/*" -DestinationPath $OutputFile
    Remove-Item "$ArtifactsDir" -Recurse -Force
    Remove-Item "$ExtraArtifactsDir" -Recurse -Force
}

function Update-SignedArchive {
    param(
        [Parameter(Mandatory)]
        [string]
        $InputFile,
        [Parameter(Mandatory)]
        [string]
        $ArtifactsDir,
        [string]
        $ReportDir,
        [Parameter(Mandatory)]
        [string]
        $OutputFile
    )

    if (-Not (Test-Path -Path "$InputFile")) {
        return
    }

    if (-Not ($OutputFile -and (Test-Path -Path "$OutputFile"))) {
        return
    }

    if (-Not (Test-Path -Path "$ArtifactsDir")) {
        return
    }

    Expand-Archive -Path "$zipPath" -DestinationPath "$ArtifactsDir"

    if ($ReportDir -and (Test-Path -Path $ReportDir)) {
        Move-Item -Path "$ArtifactsDir/*.md" -Destination $ReportDir
    }

    Compress-SignedFiles -ArtifactsDir $ArtifactsDir -ExtraArtifactsDir $ExtraArtifactsDir -OutputFile $OutputFile
}
