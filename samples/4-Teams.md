### Create a new team.
```sh
$ mgc teams create --body '{"displayName": "2020 Interns", "description": "2020 Interns", \
    "additionalProperties": {
        "template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
    }}'
```

### Filter groups by displayName and resourceProvisioningOptions to find team.
```sh
$ mgc groups list --filter "StartsWith(DisplayName, '$TeamName')" --query "value[?contains(resourceProvisioningOptions, 'Team')]"
```

### Add team owner.
```sh
$ mgc users get --user-id "{TEAM_OWNER_UPN}"
$ mgc teams members create --team-id <TeamId> --body '{"additionalProperties": {\
        "@odata.type": "#microsoft.graph.aadUserConversationMember",\
        "user@odata.bind": "https://graph.microsoft.com/v1.0/users/" + $teamOwner.id\
    }, "roles": ["owner"]}'
```

### Send a welcome message to the channel.
```sh
$ mgc teams primary-channel get --team-id <TeamId>
$ mgc teams channels messages create --team-id <TeamId> --channel-id <ChannelId> --body '{"body": {"content": "Welcome to Teams!"}}'
```

### Delete team.
```sh
$ mgc groups delete --group-id <GroupId>
```

### Teams Chat snippets

#### Get list of 1:1 chats
```sh
$ mgc chats list
```

#### Get Messages from Chat
```sh
$ mgc chats messages list --chat-id <ChatId>
```

#### Send a message in that 1:1 chat
```sh
$ mgc chats messages create --chat-id <ChatId> --body '{"body": {"content": "Hi from CLI!"}}'
```

#### Mention a user in a channel message.
```sh
$ mgc users get --user-id <UserId> --select "id, displayName, userIdentityType"
$ mgc teams channels messages create --team-id <TeamId> --channel-id <ChannelId> \
    --body $'{"body": {"contentType": "html", "content": "Welcome to the channel <at id=\'0\'>[DisplayName]</at>!"}, "mentions": [{"id": 0, "mentionText": "[DisplayName]", "mentioned": {"user": {"id": "[id]", "displayName": "[DisplayName]", "userIdentityType": "aadUser"}}}]}'
```