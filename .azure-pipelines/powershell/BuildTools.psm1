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

function Zip-BuildOutput {
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
    Remove-Item $OutputDir/*'
}