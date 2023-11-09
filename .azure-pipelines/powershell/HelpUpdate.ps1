function Replace-TextInFile {
    Param(
        [Parameter(Mandatory)]
        [string] $FilePath,
        [Parameter(Mandatory)]
        [string] $Pattern,
        [string] $Replacement
    )

    $input = [System.IO.File]::ReadAllText($FilePath)
    $output = $input -creplace $Pattern, $Replacement
    if (($input.Length -ne $output.Length) -and ($input -ne $output)) {
        [System.IO.File]::WriteAllText(
            $FilePath,
            $output
        )
    }
}

function Update-FileContent {
    param(
        [Parameter(Mandatory)]
        [ValidateScript({
            Test-Path $_ -PathType Container
        }, ErrorMessage="Source dir '{0}' is not a directory")]
        [string] $SourceDir,
        [Parameter(Mandatory)]
        [string] $Pattern,
        [string] $Replacement
    )

    Get-ChildItem -Path $SourceDir -Filter *.cs -Recurse -File | ForEach-Object {
        Replace-TextInFile -FilePath $_ -Pattern $Pattern -Replacement $Replacement
    }
}

function Update-MeUserIdHelp {
    param(
        [string] $WorkspaceRootDir = "."
    )
    $usersDir = Join-Path -Path $WorkspaceRootDir -ChildPath src\generated\Users
    Update-FileContent -SourceDir $usersDir -Pattern 'userIdOption = new Option<string>\("--user-id", description: "(.+)"\)' -Replacement 'userIdOption = new Option<string>("--user-id", description: "$1. Use ''me'' for the currently signed in user.")'
}

function Update-UsersMeAlias {
    param(
        [string] $WorkspaceRootDir = "."
    )
    $usersRb = Join-Path -Path $WorkspaceRootDir -ChildPath src\generated\GraphClient.cs
    Replace-TextInFile -FilePath $usersRb -Pattern 'command = new Command\("users"\);(\r?\n\s*)' -Replacement 'command = new Command("users");$1command.AddAlias("me");$1'
}
