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
mgc applications list --select "DisplayName, id, SignInAudience"
```

### List service principals in the tenant

```sh
mgc service-principals list --select "id, AppDisplayName" --query "value[?contains(appDisplayName, 'powershell')]"
```
