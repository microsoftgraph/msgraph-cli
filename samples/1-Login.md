## Login

### Login with default client id & tenant id

```sh
mgc login --scopes User.ReadWrite Mail.ReadWrite
```

### Login with custom client id & tenant id

```sh
mgc login --scopes User.ReadWrite Mail.ReadWrite --client-id <client id> --tenant-id <tenant id>
```

### Login using previously consented permissions

```sh
mgc login --scopes User.ReadWrite Mail.ReadWrite --client-id <client id> --tenant-id <tenant id>
```

### Login using interactive browser

```sh
mgc login --strategy InteractiveBrowser
```

### Login using client certificate

```sh
mgc login --strategy ClientCertificate
```

## Logout

Forget access tokens

```sh
mgc logout
```
