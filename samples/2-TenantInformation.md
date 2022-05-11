## Tenant information

### Organization contact details

```sh
mgc organization list
```

```sh
mgc organization list --select "DisplayName, City, State, Country, PostalCode, BusinessPhones"
```

### List application registrations in the tenant

```sh
mgc organization list --select "DisplayName, id, SignInAudience"
```

### List service principals in the tenant

```sh
mgc organization list --select "id, AppDisplayName" --query "value[?contains(appDisplayName, 'powershell')]"
```
