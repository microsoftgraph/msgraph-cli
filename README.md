# Microsoft Graph CLI

Microsoft Graph CLI SDK provides convenient methods to access Microsoft Graph capabilities using a simplistic command line interface experience on any operating system and any shell. 

## Required tools
A commandline tool should work on any terminal. We recommend:
- [Windows Terminal + version](https://apps.microsoft.com/store/detail/windows-terminal/9N0DX20HK701?hl=en-us&gl=us)
- MacOS terminal
- PowerShell version 7.3.2

## Target project requirements
Download the CLI SDK to get started for 
Windows, Mac, or Linux here on the assets link of the latest release: [CLI SDK Download](https://github.com/microsoftgraph/msgraph-cli/releases)


## Registering an application in Azure AD

> **Note:** this step is required if your client will be calling APIs that are protected by the Microsoft Identity Platform like Microsoft Graph.

Follow the instructions in [Register an application for Microsoft identity platform authentication](register-app.md) to get an application ID (also know as a client ID).

### Creating the client application

Replace `YOUR_CLIENT_ID` with the client ID from your app registration.

## Executing the application
Navigate to your download folder and use the **mgc** command to run commands on the CLI SDK. 
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
#Using the DeviceCode authentication  explicitly
mgc login --strategy DeviceCode
```

**2.Interactive Browser authentication strategy**
``` bash
# Using interactive Browser authentication.
mgc login --strategy InteractiveBrowser

```

### **App-only access**
**1. Client Certificate authentication strategy**
``` bash
# Using Client Certificate authentication.
mgc login --strategy ClientCertificate

```
### Samples
You can find additional samples here: [CLI SDK samples](https://github.com/microsoftgraph/msgraph-cli/tree/main/samples)


> Note: This repository is for the .NET CLI. If you are looking for the Python CLI, it's been moved to the [msgraph-cli-archived](https://github.com/microsoftgraph/msgraph-cli-archived) repository
