### Create a new team

PowerShell:

```powershell
$TeamName = "2020 Interns"
$body = ConvertTo-Json '{"displayName": $TeamName, "description": $TeamName, "additionalProperties": { "template@odata.bind": "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"}}'
mgc teams create --body $body
```

Bash:

```sh
TeamName = "2020 Interns"
mgc teams create --body '{"displayName": $TeamName, "description": $TeamName,
    "additionalProperties": {
        "template@odata.bind": "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
    }}'
```

### Filter groups by displayName and resourceProvisioningOptions to find team

PowerShell:

```powershell
$InternsTeam = mgc groups list --filter "StartsWith(DisplayName, '$TeamName')" --query "value[?contains(resourceProvisioningOptions, 'Team')]"
```

Bash:

```sh
InternsTeam=$(mgc groups list --filter "StartsWith(DisplayName, '$TeamName')" --query "value[?contains(resourceProvisioningOptions, 'Team')]")
```

### Add team owner

PowerShell:

```powershell
$teamOwner=mgc users get --user-id "{TEAM_OWNER_UPN}"
mgc teams item members create --team-id $InternsTeam.id --body '{"additionalProperties": {
        "@odata.type": "#microsoft.graph.aadUserConversationMember",
        "user@odata.bind": "https://graph.microsoft.com/v1.0/users/" + $teamOwner.id
    }, "roles": ["owner"]}'
```

Bash:

```sh
teamOwnerId=$(mgc users get --user-id "{TEAM_OWNER_UPN}" | grep -o '"id": "[^"]*' | grep -o '[^"]*$')
teamId=$(echo $InternsTeam | grep -o '"id": "[^"]*' | grep -o '[^"]*$')

mgc teams item members create --team-id $teamId --body '{"additionalProperties": {
        "@odata.type": "#microsoft.graph.aadUserConversationMember",
        "user@odata.bind": "https://graph.microsoft.com/v1.0/users/" + $teamOwnerId
    }, "roles": ["owner"]}'
```

### Send a welcome message to the channel

PowerShell:

```powershell
$PrimaryChannel = mgc teams item primary-channel get --team-id $InternsTeam.id
$body = ConvertTo-Json '{"body": {"content": "Welcome to Teams!"}}'
mgc teams item channels item messages create --team-id $InternsTeam.id --channel-id $PrimaryChannel.id --body $body
```

Bash:

```sh
PrimaryChannelId=$(mgc teams item primary-channel get --team-id $teamId | grep -o '"id": "[^"]*' | grep -o '[^"]*$')
mgc teams item channels item messages create --team-id $teamId --channel-id $PrimaryChannelId --body '{"body": {"content": "Welcome to Teams!"}}'
```

### Delete team

PowerShell:

```powershell
mgc groups delete --group-id $InternsTeam.id
```

Bash:

```sh
mgc groups delete --group-id $teamId
```

### Teams Chat snippets

#### Get list of 1:1 chats

```sh
mgc chats list
```

#### Get Messages from Chat

```sh
mgc chats item messages list --chat-id <ChatId>
```

#### Send a message in that 1:1 chat

```sh
mgc chats item messages create --chat-id <ChatId> --body '{"body": {"content": "Hi from CLI!"}}'
```

#### Mention a user in a channel message

PowerShell:

```powershell
$user = mgc users item get --user-id <UserId> --select "id, displayName, userIdentityType"
$body = ConvertTo-Json '{"body": {"contentType": "html", "content": "Welcome to the channel <at id=\'0\'>${user.displayName}</at>!"}, "mentions": [{"id": 0, "mentionText": "${user.displayName}", "mentioned": {"user": {"id": "${user.id}", "displayName": "${user.displayName}", "userIdentityType": "${user.userIdentityType}"}}}]}'
mgc teams item channels item messages create --team-id <TeamId> --channel-id $PrimaryChannel.id \
    --body $body
```

Bash:

```sh
user=$(mgc users item get --user-id <UserId> --select "id, displayName, userIdentityType")
userId=$(echo $user | grep -o '"id": "[^"]*' | grep -o '[^"]*$')
userDisplayName=$(echo $user | grep -o '"displayName": "[^"]*' | grep -o '[^"]*$')
userIdentityType=$(echo $user | grep -o '"userIdentityType": "[^"]*' | grep -o '[^"]*$')
mgc teams item channels item messages create --team-id <TeamId> --channel-id $PrimaryChannelId \
    --body '{"body": {"contentType": "html", "content": "Welcome to the channel <at id=\'0\'>${userDisplayName}</at>!"}, "mentions": [{"id": 0, "mentionText": "${userDisplayName}", "mentioned": {"user": {"id": "${userId}", "displayName": "${userDisplayName}", "userIdentityType": "${userIdentityType}"}}}]}'
```
