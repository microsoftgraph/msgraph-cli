# To get around the bug in https://github.com/moby/buildkit/issues/1366 on windows hosts, you can either:
#   1. Enable long file path support in windows
#   2. Use the \\?\ prefix when specifying the path in the docker build command. e.g.
#      docker build \\?\C:\path -f .\Dockerfile
# See https://docs.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build-env

ARG MS_NUGET_URL=https://nuget.pkg.github.com/microsoft/index.json

WORKDIR /app

COPY ./src ./msgraph-cli/src
COPY ./msgraph-cli-core ./msgraph-cli/msgraph-cli-core
WORKDIR /app/msgraph-cli

RUN --mount=type=secret,id=user,required=true --mount=type=secret,id=token,required=true \
    dotnet nuget add source ${MS_NUGET_URL} -n ms-gh -u $(cat /run/secrets/user) -p $(cat /run/secrets/token) --store-password-in-clear-text

RUN dotnet publish -p:PublishSingleFile=false -p:PublishReadyToRun=true -p:PublishReadyToRunShowWarnings=true ./src/msgraph-cli.csproj --configuration Release --no-self-contained --runtime linux-musl-x64 --output /app/output

FROM mcr.microsoft.com/dotnet/runtime:6.0-alpine as runtime

# Change this password by providing a different value when running the container
ENV KEYRING_PASSWORD="password"

RUN apk add --no-cache libsecret dbus gnome-keyring libcap &&\
    dbus-uuidgen > /var/lib/dbus/machine-id &&\
    setcap cap_ipc_lock=+ep $(which gnome-keyring-daemon)

RUN addgroup mgc &&\
    adduser -D -G mgc -h /app mgc

WORKDIR /app

COPY --from=build-env /app/output ./dist

RUN ln -s /app/dist/mgc /usr/bin/mgc

USER mgc

COPY --chown=mgc:mgc ./docker/* ./dist/

RUN mkdir -p /app/.mgc /app/.local/share/.IdentityService /app/.local/share/keyrings &&\
    chmod +x /app/dist/init.sh

VOLUME [ "/app/.mgc", "/app/.local/share/.IdentityService", "/app/.local/share/keyrings" ]

ENTRYPOINT ["./dist/init.sh"]

LABEL description="# Welcome to the Microsoft Graph CLI  \
[Source dockerfile](https://github.com/microsoftgraph/msgraph-cli/blob/main/Dockerfile)"