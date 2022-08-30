## Microsoft Graph Users and Groups Snippets

### List of users (paged)

Get first page of users. If the `--top` command option is not provided, the page size is determined by the server.

```sh
mgc users list --select "id, displayName, OfficeLocation, BusinessPhones"
```

### List of all users

```sh
mgc users list --select "id, displayName, OfficeLocation, BusinessPhones" --all
```

### List users with count

```sh
mgc users list --top 5 --count --consistency-level eventual
```

### List of users with no Office Location

```sh
mgc users list --select "id, displayName, OfficeLocation, BusinessPhones" --query "value[?!officeLocation]"
```

### Update the location of the user

Powershell:

```powershell
$body = ConvertTo-Json '{"officeLocation": "NewLocation"}'
mgc users item patch --user-id <UserId> --body $body
```

Bash:

```sh
mgc users item patch --user-id <UserId> --body '{"officeLocation": "NewLocation"}'
```

### Get all Groups

```sh
mgc groups list --select "id, DisplayName, GroupTypes"
```

### Get all unified (Microsoft 365 Groups) Groups

```sh
mgc groups list --filter "groupTypes/any(c:c eq 'Unified')"
```

### Get-Details of a single Group

```sh
mgc groups item get --group-id <GroupId>
```

### Get Owners of a Group

```sh
mgc groups item owners list --group-id <GroupId>
```

### Get Members of a Group

```sh
mgc groups members list --group-id <GroupId>
```

### Get your mail

```sh
mgc users item messages list --user-id <UserId> --filter "contains(subject,'Marketing')" --select "sentDateTime, subject"
```

### New Group

Powershell:

```powershell
$body = ConvertTo-Json '{"displayName": "PowerFam", "mailEnabled": false, "mailNickName": "powerfam", "securityEnabled": true}'
mgc groups create --body $body
```

Bash:

```sh
mgc groups create --body '{"displayName": "PowerFam", "mailEnabled": false, "mailNickName": "powerfam", "securityEnabled": true}'
```

### Remove Group

```sh
mgc groups item delete --group-id <GroupId>
```

### Create a new User

PowerShell:

```powershell
$body = ConvertTo-Json '{"displayName": "Bob Brown", "accountEnabled": true, "passwordProfile": {"password": "password"},\
        "mailNickname": "Bob.Brown", "userPrincipalName": "bob.brown@{tenantdomain}"}'
mgc users create --body $body
```

Bash:

```sh
mgc users create --body '{"displayName": "Bob Brown", "accountEnabled": true, "passwordProfile": {"password": "password"},\
        "mailNickname": "Bob.Brown", "userPrincipalName": "bob.brown@{tenantdomain}"}'
```
