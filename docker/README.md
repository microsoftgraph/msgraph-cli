# Microsoft Graph CLI
## Docker Image Help

### Quick start
#### Running the container
If you are using docker-compose:
```sh
$ docker-compose run -it mgc sh
```

Otherwise use docker to run the container.
```sh
$ docker run -it --cap-add=IPC_LOCK --rm msgraph-cli sh
```

> The IPC_LOCK capability is required by the `gnome-keyring-daemon` process which
> performs token encryption.

#### Building an image
Set the `NUGET_USER` and `NUGET_TOKEN` environment variables to a token that has pull package access to the [microsoft](https://github.com/microsoft) and [microsoftgraph](https://github.com/microsoftgraph) GitHub organizations.

To build an image in windows powershell:
```powershell
$ docker build \\?\$(Get-Location) -f . -t msgraph-cli --build-arg NUGET_USER=$env:NUGET_USER --build-arg NUGET_PASSWORD=$env:NUGET_TOKEN
```

> The `\\?\$(Get-Location)` section of the command is used to get around the 260 character
> limitation on windows systems that could cause issues when copying files to the docker
> context. This issue impacts buildkit builds. For more information, check [this issue](https://github.com/moby/buildkit/issues/1366).

To build an image in linux or WSL:
```sh
$ docker build -t msgraph-cli --build-arg NUGET_USER=$NUGET_USER --build-arg NUGET_PASSWORD=$NUGET_TOKEN .
```