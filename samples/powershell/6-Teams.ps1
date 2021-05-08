# Based on https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/samples/5-Teams.ps1
# mg login --scopes "Team.Create, Group.ReadWrite.All, Directory.ReadWrite.All, TeamMember.ReadWrite.All"

# Incremental consent works great.

# List all teams. Have to use groups which are not implemented.
mg teams team list # This is not how you list teams.
# https://docs.microsoft.com/en-us/graph/teams-list-all-teams?context=graph%2Fapi%2F1.0&view=graph-rest-1.0

# Random note - it would be nice to be to submit a random command from the command line. Like `mg get "\me\messages?$select=subject,id" --output table 


