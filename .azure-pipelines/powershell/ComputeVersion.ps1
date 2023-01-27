Param(
    [string]
    $BranchOrTagName = "latest"
)
# Get the version
$version = "$BranchOrTagName"
$version = $version.TrimStart('refs/tags/v')
# Return the version
Write-Output $version