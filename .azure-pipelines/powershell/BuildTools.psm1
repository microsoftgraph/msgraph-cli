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

    $outputLocation = "$OutputDir-$RuntimeIdentifier"
    $zipName = Get-ZipName -FileNameTemplate $FileNameTemplate -BranchOrTagName $BranchOrTagName -RuntimeIdentifier $RuntimeIdentifier
    $zipPath = Join-Path -Path $outputLocation -ChildPath $FileName

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
