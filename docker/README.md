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
Ensure you have a docker engine with API access [1.39+](https://docs.docker.com/engine/api/v1.39/) and BuildKit enabled.
Create 2 files `nuget_user.txt` and `nuget_token.txt` and set their content to a username and a matching personal access token
that has pull access to both the [microsoft](https://github.com/microsoft) and [microsoftgraph](https://github.com/microsoftgraph)
GitHub organizations' package registries.

To build an image in windows powershell:
```powershell
$ docker build \\?\$(Get-Location) -f . -t msgraph-cli --secret id=user,src=./tmp/nuget_user.txt --secret id=token,src=./tmp/nuget_token.txt
```

> The `\\?\$(Get-Location)` section of the command is used to get around the 260 character
> limitation on windows systems that could cause issues when copying files to the docker
> context. This issue impacts buildkit builds. For more information, check
> [this issue](https://github.com/moby/buildkit/issues/1366).

To build an image in linux or WSL:
```sh
$ docker build -t msgraph-cli --secret id=user,src=./tmp/nuget_user.txt --secret id=token,src=./tmp/nuget_token.txt .
```