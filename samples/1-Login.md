## Login
Login with default client id & tenant id

```sh
$ mgc login --scopes User.ReadWrite Mail.ReadWrite
```

Login with custom client id & tenant id

```sh
$ mgc login --scopes User.ReadWrite Mail.ReadWrite --client-id <client id> --tenant-id <tenant id>
```

## Logout
Forget access tokens

```sh
$ mgc logout
```