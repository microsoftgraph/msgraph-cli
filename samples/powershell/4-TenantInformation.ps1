# TODO: Organization entity set is not yet available

# 1. Organization Contact Details
#Get-MgOrganization | Select-Object DisplayName, City, State, Country, PostalCode, BusinessPhones

# 2. Organization Assigned Plans
#Get-MgOrganization | Select-Object -expand AssignedPlans

# 3. List application registrations in the tenant

.\mg applications application list --select "DisplayName, Appid, SignInAudience"

# Results:

<#
Two application objects with all properties are the output.

TODO:
It should be noted that I can't use Fiddler with the CLI. 
We may need to be able to use that to inspect the traffic although debug is certainly helpful.

Running the above command with --debug flag results in a lot of interesting.
a) A log file is written to c:\users\{user}\.mg\commands - the log file has nothing interesting in it except the
   command that was run.
b) There is proper redaction of sensitive info. Does id_token need to be redacted?
c) Information about scopes is helpful.
d) request-id is present.

TODO:
- Either remove log file generation or provide actual info in it. If we do the later, let customers know, and doc it.
- Should we output id_token?
#>

.\mg applications application list --query "[]" --output table


# Result
<#

Outputs only non-null properties.

AppId                                 CreatedDateTime            DisplayName                        PublisherDomain           SignInAudience    IsFallbackPublicClient
------------------------------------  -------------------------  ---------------------------------  ------------------------  ----------------  ------------------------
f31c59c3-bc6e-422f-87e0-a6d1afb157bc  2020-09-16T23:33:17+00:00  Chambele Linqpad ClientCredential  chambele.onmicrosoft.com  AzureADMyOrg
6881477a-a153-4bf1-973e-60abfad70ad5  2020-12-04T16:25:33+00:00  Chambele Linqpad PublicClient      chambele.onmicrosoft.com  AzureADMyOrg      True

#>

.\mg applications application list --query "[?appId=='6881477a-a153-4bf1-973e-60abfad70ad5'].{appname: displayName, aud: signInAudience}"

# Result

<#
[
  {
    "appname": "Chambele Linqpad PublicClient",
    "aud": "AzureADMyOrg"
  }
]
#>

<# Note
Performs a transform of property names for results.

TODO: While GE is case-insensitive, the CLI is case-sensitive for these queries. For example, the query won't take 'displayname'. Need to document this.
https://graph.microsoft.com/v1.0/applications?$filter=appid eq 'f31c59c3-bc6e-422f-87e0-a6d1afb157bc'&$select=displayname
#>

.\mg applications application list --query "[?appId=='6881477a-a153-4bf1-973e-60abfad70ad5'].{appname: displayName, aud: signInAudience}" --output table

# Result
<#
Appname                        Aud
-----------------------------  ------------
Chambele Linqpad PublicClient  AzureADMyOrg
#>

# TODO: ServicePrincipal entity set is not yet available

## List service principals in the tenant
# Get-MgServicePrincipal | Select-Object id, AppDisplayName | Where-Object { $_.AppDisplayName -like "*powershell*" }