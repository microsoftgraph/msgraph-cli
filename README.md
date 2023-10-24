# Microsoft Graph CLI

Microsoft Graph CLI provides convenient methods to access Microsoft Graph capabilities using a simplistic command line interface experience on any operating system and any shell.

## Required tools
A command line tool should work on any terminal. We recommend:
- [Windows Terminal + version](https://apps.microsoft.com/store/detail/windows-terminal/9N0DX20HK701?hl=en-us&gl=us)
- MacOS (Minimum version: 10.12 Sierra) terminal
- PowerShell version 7.3.2

## Installation

### DotNet Tool

```
dotnet tool install --global Microsoft.Graph.Cli --prerelease
```

### Manual

To download the CLI to get started for Windows, Mac, or Linux.
 here on the assets link of the latest release: [CLI Download](https://github.com/microsoftgraph/msgraph-cli/releases)


#### Windows
1. Extract downloaded CLI tool for Windows to folder
2. Execute program using **mgc** (on Windows CMD) or **./mgc** (on Windows PowerShell) command.


##### Windows environment setup (Optional)

To allow executing the mgc command without prefixing it with `./`, you can add the executable's directory to the OS Path environment variable.
On Windows PowerShell, you can add the current directory to the path by running:

```powershell
$env:Path += ";$(pwd)"
```

On CMD, the command becomes:
```cmd
set PATH=%PATH%;%cd%
```

Though adding the current directory to the path doesn't change how you run mgc on CMD, it allows you to switch the directory you're working in.
This is useful for when you need to use a different directory to save files downloaded from the CLI.

The commands above will update your Path for the current command session, and will need to be run whenever you start a new session e.g. when opening a new window.
To make the changes permanent, you can update the environment variables by using the **System properties** dialog.
You can find it by either using windows search (it appears as _view advanced system settings_) in the start menu, or following the steps below:

1. Open the **Settings** app
2. Click on **System**
3. Select the **About** option. It should be the last one in the list.
4. In the **About** screen, locate and click on the _Advanced system settings_ link in the **Related links** section just below the device specifications.
5. Once the dialog is open, click on the **Environment Variables** button on the bottom right.
6. Select the Path environment variable and click **Edit**.
7. Add the directory with the CLI to the path here.

> The Environment Variables screen should have 2 sections that both have a Path entry. The _User variables_ section adds to the current user's path and other users' environments should remain unchanged. The _System variables_ section will make the changes for all users in the computer.


#### MacOS

1. Download the CLI archive for your Mac.
    - If you have an M1 Mac computer, download the `msgraph-cli-osx-arm64...` package.
    - If you have an Intel processor, download the `msgraph-cli-osx-x64...` package.
2. Extract downloaded CLI tool for Mac to a folder.
3. Open a terminal in the new folder
4. Execute the program using **./mgc** command.

##### Mac environment setup (Optional)

If you'd like to run the CLI from any folder, you need to either update the PATH environment variable for your shell,
or add a symbolic link to the CLI into a location in the PATH (e.g. /usr/bin). Adding a symbolic link will need
super user rights depending on the location you choose.

Adding to the PATH for your current session is also an option as it is in Windows. To do this, run the following command
from your terminal in the directory of the CLI:

```sh
export PATH=$PATH:$(PWD)
```

Adding the location permanently can be done for the current user by editing your `~/.bash-profile` file.
Add the following line to your profile:

```sh
export PATH=$PATH:[path-to-the-cli-folder]
```

Adding a symbolic link into `/usr/bin` (not recommended) can be done with the command below:

```sh
sudo ln -s [path-to-the-cli-folder]/mgc /usr/bin
```


#### Linux

Download from browser OR via Curl

``` bash
curl -LO <link> && tar -xzf <filename>
```

##### Linux (Ubuntu) environment setup (Required)

The linux environment setup is similar to the Mac setup, but with one difference. For headless linux environments,
there's an additional step to configure the keyring for access token encryption.

To set up the PATH environment variable for your current session, run the following command from your terminal
in the directory of the CLI:

```sh
export PATH=$PATH:$(PWD)
```

Adding the location permanently can be done for the current user by editing your shell's profile file
(`~/.bash-profile` or `~/.zsh-profile`) file. Add the following line to your profile:

```sh
export PATH=$PATH:[path-to-the-cli-folder]
```

Adding a symbolic link into `/usr/bin` (not recommended) can be done with the command below:

```sh
sudo ln -s [path-to-the-cli-folder]/mgc /usr/bin
```


>**Note:** The following step is **Required** if your linux distribution does not have a desktop environment e.g. WSL, Docker
Failure to set this up will result in authentication failures.

Required packages:

1. systemd (ensure the dbus service is properly set up)
2. dbus
3. gnome-keyring

> On WSL, systemd can be enabled by following [these instructions](https://learn.microsoft.com/en-us/windows/wsl/systemd)

1. Install gnome-keyring
``` bash
sudo apt-get install --assume-yes gnome-keyring

```

2. If running in a headless environment(e.g. WSL), you may need to run the following commands as well to start gnome-keyring in your shell session:

```bash
export KEYRING_PASSWORD=any-password

printf '%s' "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock
```

3. Run mgc

```bash

mgc login
```

See the [shell script](docker/init.sh) used for docker in this repository

### Using Docker
Find docker instructions in the docker folder [here](docker)

## Uninstalling
### Dotnet tool

```
dotnet tool uninstall Microsoft.Graph.Cli
```

### Manual

1. Delete the CLI installation folder
2. If path enviroment variable had been set, remove it.

## Registering an application in Azure AD

> **Note:** this step is **NOT** required unless your client will be calling APIs that are protected by the Microsoft Identity Platform like Microsoft Graph OR using Client Certificate authentication option.

Follow the instructions in [Register an application for Microsoft identity platform authentication](register-app.md) to get an application ID (also know as a client ID).

Replace `YOUR_CLIENT_ID` with the client ID from your app registration.

## Executing the application
Navigate to your download folder and use the **mgc** (on Windows/Mac) or **./mgc** (on WSL or Linux) command to run commands on the CLI.

Add -h to your commands to view additional commands.

## Authenticating on the CLI tool
CLI supports both delegeted and app-only authentication strategies. Run the command below to see supported authentication strategies.

``` bash
#View supported authentication strategies. Default is Device Code
mgc login --help
```
OR

``` bash
mgc login --client-id `YOUR_CLIENT_ID` --tenant-id `YOUR_TENANT_ID` --scopes User.ReadWrite --scopes Mail.ReadWrite
```

### **Delegated access**

**1. DeviceCode authentication strategy**

``` bash
#Using the Default authentication (which is Device Code)
mgc login
```
OR

``` bash
#Using the DeviceCode authentication explicitly
mgc login --strategy DeviceCode
```

**2.Interactive Browser authentication strategy**
``` bash
# Using interactive Browser authentication.
mgc login --strategy InteractiveBrowser

```

### **App-only access**
**1. Client Certificate authentication strategy**
> **Note:** Registering an application is required when using Client Certificate

``` bash
# Using Client Certificate authentication.
mgc login --strategy ClientCertificate
```

## Permissions
Add -h to your command to view information that contains documentation links with permissions

## Check logged in user
You can access the your user's details using:
```bash
mgc users get --user-id 'your_email@example.com'
```

This will also display your User ID which is required for many queries involving your user (the "me" concept has been removed from Microsoft Graph CLI).

## FAQs
Qn: Why am I not getting a response back after running a command?

Ans:add --debug to your command

## Samples
You can find additional samples here (contains sample commands for CMD, PowerShell & Bash) [CLI samples](https://github.com/microsoftgraph/msgraph-cli/tree/main/samples)


> Note: This repository is for the .NET CLI. If you are looking for the Python CLI, it's been moved to the [msgraph-cli-archived](https://github.com/microsoftgraph/msgraph-cli-archived) repository
