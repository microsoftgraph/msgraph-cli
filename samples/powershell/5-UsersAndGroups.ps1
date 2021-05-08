# Microsoft Graph Users and Groups Snippets
# Based on https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/samples/4-UsersAndGroups.ps1
# mg login --scopes "user.readwrite.all,group.readwrite.all"

# no concept of ME for user; $top, $filter, $search, $count, $skip, $format not supported.

# List of Users
mg users user list --select "id, displayName, OfficeLocation, BusinessPhones" --output table # works, but the table is missing id and businessPhones.
mg users user list --top 2 --select "id, displayName, OfficeLocation, BusinessPhones" --output table # top is not supported

# General: we are missing a lot of query parameters with top and filter mostly missing. Looks like we have support for expand and select.

# List of users with no Office Location - not supported as we need filter support.
mg users user list --select "Id, displayName, OfficeLocation, BusinessPhones" --output table

# Order users
mg users user list --select "Id, displayName, OfficeLocation, BusinessPhones" --orderby "displayName" --output table

# Get specific user - works, but the table output doesn't make sense. It is very trunctated. The entire content is returned in JSON
mg users user show-user --user-id e8887f06-c72c-49a6-8788-d6a86300dea7 --output table

# Get specific user and expand manager - this works
mg users user show-user --user-id e8887f06-c72c-49a6-8788-d6a86300dea7 --expand "manager"

# Update the location of the user - Update doesn't exist anylonger!
mg users user update --user-id $userId --office-location $newLocation

# Create a user - fails, looks like we are sending the entire object with null values.
mg users user create --display-name "Temp User"
#> (BadRequest) The following properties cannot be set in the initial POST request. Please set them in a subsequent PATCH request: mailboxSettings, inferenceClassification, outlook, planner, insights, settings, onenote.

# Delete a user
mg users user delete-user --user-id "1d9f1b45-09cd-4615-8101-5de9d841da30" 

# - All of the groups functionality is missing from the CLI package.

# Get all Groups 
mg groups group list --select "id, DisplayName, GroupTypes" --orderby "DisplayName" --output table

# Get all unified (Microsoft 365 Groups) Groups
Get-MgGroup -Filter "groupTypes/any(c:c eq 'Unified')"

# Get-Details of a single Group
Get-MgGroup -GroupId $groupId | Format-List | more

# Get Owners of a Group
Get-MgGroupOwner -GroupId $GroupId 

# Translate Directory Objects to Users 
Get-MgGroupOwner -GroupId $GroupId | ForEach-Object { @{ UserId=$_.Id}} | get-MgUser | Select-Object id, DisplayName, Mail

# Could do the same for Group Members
Get-MgGroupMember -GroupId $GroupId 

# Get your mail
Get-MgUserMessage -UserId $UserId -Filter "contains(subject,'Marketing')" | Select-Object sentDateTime, subject

# New Group
$group = New-MgGroup -DisplayName "PowerFam" -MailEnabled:$false -mailNickName "powerfam" -SecurityEnabled

# Add member to Group  
New-MgGroupMember -GroupId $Group.Id -DirectoryObjectId $UserId

# View new member to Group
Get-MgGroupMember -GroupId $group.Id  | ForEach-Object { @{ UserId=$_.Id}} | Get-Mguser | Select-Object id, DisplayName, Mail

#Remove Group
Remove-MgGroup -GroupId $Group.Id