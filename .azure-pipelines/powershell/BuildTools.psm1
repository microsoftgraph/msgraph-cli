function Zip-Build-Output {
    param(
        [Parameter(Mandatory)]
        [string]
        $FileName,
        [Parameter(Mandatory)]
        [string]
        $OutputDir,
        [string]
        $RuntimeIdentifier = "unknown"
    )

    if (-Not (Test-Path -Path $OutputDir)) {
        New-Item $OutputDir -ItemType Directory
    }

    $outputLocation = "$OutputDir-$RuntimeIdentifier"
    $zipPath = Join-Path -Path $outputLocation -ChildPath $FileName

    Compress-Archive -Path $OutputDir/* -DestinationPath $zipPath
    Remove-Item $OutputDir/*'
}