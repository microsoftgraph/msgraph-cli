# Validate the login experience - TODO: validate from MSI

# Incremental consent works great.

# 1. Login without scopes before installing wheels

.\mg login

# Result:

<#
WARNING: No module named 'azext_identitydirmgt_v1_0'
usage: mg login [-h] [--verbose] [--debug] [--only-show-errors] [--output {json,jsonc,yaml,yamlc,table,tsv,none}] [--query JMESPATH] --scopes SCOPES [--client-id CLIENT_ID]
                [--tenant-id TENANT_ID]
mg login: error: the following arguments are required: --scopes
#>

# 2. Login with scopes before installing wheels

.\mg login --scopes user.read

# Results:

<#
WARNING: No module named 'azext_identitydirmgt_v1_0'
Logged in successfully
#>

# 3. Incremental login with new scope after installing wheels against tenant where user consent is disabled

.\mg login --scopes mail.read

# Results:

<#
ERROR: Authentication failed: ['access_denied']
#>

# TODO: Consider handling with a user friendly message to indicate that either: 1) the scope is not applicable to delegate auth, 
# 2) they may need to acquire admin consent to use the scope. This brings up another set of questions around how is the app
# registered and what is the auth story.

# 4. Login 

.\mg login --scopes "mail.read User.ReadWrite.All Mail.ReadWrite Directory.Read.All Chat.ReadWrite People.Read Group.Read.All Tasks.ReadWrite Sites.Manage.All"

# Results

<#
Logged in successfully
#>

# Note: the CLI is unverified - we need to have a path to making it verified. This is noted in the consent screen. 
# I also had to consent using an admin. We need to nail the story around how regular users can use the CLI.

# 5. Logout

.\mg logout

<#
Logged out successfully
#>

# Note: What are we actually doing? Just deleting the access token? Is there a refresh token?

.\mg logout

<#
You're already logged out
#>

# Running logout again gives us this message. Nit: You already logged out.

# 6. Login with leading whitespace

.\mg login --scopes " Application.ReadWrite.All"

<#
Logged in successfully
#>

# TODO: What is the unattended story for when there isn't a user?
# Question: How do we specify v1.0 and beta targets?