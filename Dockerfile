FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

ARG MS_NUGET_URL=https://nuget.pkg.github.com/microsoft/index.json
ARG MSGRAPH_NUGET_URL=https://nuget.pkg.github.com/microsoftgraph/index.json
ARG NUGET_USER
ARG NUGET_PASSWORD

WORKDIR /app

COPY ./src ./msgraph-cli/src
COPY ./msgraph-cli-core ./msgraph-cli/msgraph-cli-core
WORKDIR /app/msgraph-cli

RUN dotnet nuget add source ${MS_NUGET_URL} -n ms-gh -u ${NUGET_USER} -p ${NUGET_PASSWORD} --store-password-in-clear-text &&\
    dotnet nuget add source ${MSGRAPH_NUGET_URL} -n msgraph-gh -u ${NUGET_USER} -p ${NUGET_PASSWORD} --store-password-in-clear-text

RUN dotnet publish ./src/msgraph-cli.csproj --configuration Release --no-self-contained -p:PublishSingleFile=false -p:PublishReadyToRun=false

FROM mcr.microsoft.com/dotnet/runtime:6.0 as runtime

WORKDIR /app

COPY --from=build-env /app/msgraph-cli/src/bin/Release/net6.0/ ./dist
RUN echo 'export PATH=$PATH:/app/dist' > /app/.bash_profile

ENV HOME=/app

# CMD ["bash", "-l"]
ENTRYPOINT ["/app/dist/mgc"]

LABEL description="# Welcome to the Microsoft Graph CLI  \
[Source dockerfile](https://github.com/microsoftgraph/msgraph-cli/blob/main/Dockerfile)"