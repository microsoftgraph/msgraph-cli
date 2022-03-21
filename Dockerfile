FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine3.15 AS build-env

ARG MS_NUGET_URL=https://nuget.pkg.github.com/microsoft/index.json
ARG MSGRAPH_NUGET_URL=https://nuget.pkg.github.com/microsoftgraph/index.json
ARG NUGET_USER
ARG NUGET_PASSWORD

WORKDIR /app

COPY ./src ./msgraph-cli/src
COPY ./msgraph-cli-core ./msgraph-cli/msgraph-cli-core
RUN ls -al ./msgraph-cli/src/generated/DeviceManagement/ApplePushNotificationCertificate
WORKDIR /app/msgraph-cli

RUN dotnet nuget add source ${MS_NUGET_URL} -n ms-gh -u ${NUGET_USER} -p ${NUGET_PASSWORD} --store-password-in-clear-text &&\
    dotnet nuget add source ${MSGRAPH_NUGET_URL} -n msgraph-gh -u ${NUGET_USER} -p ${NUGET_PASSWORD} --store-password-in-clear-text

RUN dotnet publish ./src/msgraph-cli.csproj --configuration Release --no-self-contained -p:PublishSingleFile=false -p:PublishReadyToRun=false

FROM mcr.microsoft.com/dotnet/runtime:6.0-alpine3.15 as runtime
WORKDIR /app

COPY --from=build-env /app/msgraph-cli/src/msgraph-cli/bin/Release/net6.0/publish ./

ENV HOME=/app/home

ENTRYPOINT ["dotnet", "mgc.dll"]
LABEL description="# Welcome to the Microsoft Graph CLI  \
[Source dockerfile](https://github.com/microsoftgraph/msgraph-cli/blob/main/Dockerfile)"