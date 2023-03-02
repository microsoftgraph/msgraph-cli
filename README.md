# Microsoft Graph CLI

Microsoft Graph CLI SDK provides convenient methods to access Microsoft Graph capabilities using a simplistic command line interface experience on any operating system and any shell. 

## Required tools
A commandline tool should work on any terminal. We recommend:
- [Windows Terminal + version](https://apps.microsoft.com/store/detail/windows-terminal/9N0DX20HK701?hl=en-us&gl=us)
- MacOS terminal
- PowerShell version 7.3.2

## Installation
Download the CLI SDK to get started for 
Windows, Mac, or Linux here on the assets link of the latest release: [CLI SDK Download](https://github.com/microsoftgraph/msgraph-cli/releases)

### Windows
1. Extract downloaded CLI tool for Windows to folder
2. Execute program using **mgc** (on Windows/Mac) or **./mgc** (on WSL or Linux) command

**Windows environment setup**


### Mac
1. Extract downloaded CLI tool for Mac to folder
2. Execute program using **mgc** (on Windows/Mac) or **./mgc** (on WSL or Linux) command

**Mac environment setup**


### Linux
Download from browser OR via Curl
``` bash
curl -LO <link> && tar -xzf <filename>
```

Add environment setup to ensure commands are not run every time. Edit environment files

>**Note:** For linux users please run the following commands before authenticating
``` bash
sudo apt install gnome-keyring libsecret-1-0

sudo setcap cap_ipc_lock=+ep $(which gnome-keyring-daemon)

export DBUS_SESSION_BUS_ADDRESS=$(dbus-daemon --session --fork --print-address)

export KEYRING_PASSWORD=any-password

dbus-run-session -- echo "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock

mgc login
```
**Linux environment setup**

--insert steps here

### Using Docker
Find docker instructions in the docker folder [here](https://github.com/microsoftgraph/msgraph-cli/tree/main/docker)

## Uninstalling
1. Delete the CLI installation folder
2. If path enviroment variable had been set, remove it.

## Registering an application in Azure AD

> **Note:** this step is **NOT** required unless your client will be calling APIs that are protected by the Microsoft Identity Platform like Microsoft Graph OR using Client Certificate authentication option.

Follow the instructions in [Register an application for Microsoft identity platform authentication](register-app.md) to get an application ID (also know as a client ID).

Replace `YOUR_CLIENT_ID` with the client ID from your app registration.

## Executing the application
Navigate to your download folder and use the **mgc** (on Windows/Mac) or **./mgc** (on WSL or Linux) command to run commands on the CLI SDK.

Add -h to your commands to view additional commands.

## Authenticating on the CLI tool
The SDK supports both delegeted and app-only authentication strategies. Run the command below to see supported authentication strategies.

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
You can access the logged in user's details using: 
```bash
mgc me get
```

## FAQs
Qn: Why am I not getting a response back after running a command?

Ans:add --debug to your command

## Samples
You can find additional samples here (contains sample commands for CMD, PowerShell & Bash) [CLI SDK samples](https://github.com/microsoftgraph/msgraph-cli/tree/main/samples)


> Note: This repository is for the .NET CLI. If you are looking for the Python CLI, it's been moved to the [msgraph-cli-archived](https://github.com/microsoftgraph/msgraph-cli-archived) repository
