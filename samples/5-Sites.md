## Microsoft Graph Sites Snippets

### Get root site

```sh
mgc sites item get --site-id root --select "id, displayName"
```

### Search for sites

```sh
mgc sites list --search "marketing" --select "displayName, description, webUrl"
```

### Get Id for marketing site

```sh
mgc sites list --search "marketing" --select id
```

### Get Site Pages

```sh
mgc sites item sites list --site-id <SiteId>
```

### Get Site Lists

```sh
mgc sites item sites list --site-id <SiteId> --select "id, displayName"
```

### Get Document Libraries

```sh
mgc sites item drive get --site-id <SiteId>
```
