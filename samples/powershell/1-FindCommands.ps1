# 1. Validate help command before installing wheels

.\mg -h

# Results:

<#
You're using the default profile

CLOUD: {'name': 'PUBLIC', 'graph_endpoint': 'https://graph.microsoft.com', 'azure_ad_endpoint': 'https://login.microsoftonline.com'}
VERSION: v1.0

Run mg profile -h for profile commands

WARNING: No module named 'azext_identitydirmgt_v1_0'

Group
    mg

Subgroups:
    profile

Commands:
    login   : Log in to Microsoft Graph.
    logout  : Log out of Microsoft Graph.
#>

# 2. Validate help command after installing wheels

.\mg -h

# Results:

<#
Group
    mg

Subgroups:
    applications
    calendar
    changenotifications
    cloudcommunications
    crossdeviceexperiences
    devicescorpmgt
    directoryobjects
    education
    identitydirmgt
    identitysignins
    mail
    people
    personalcontacts
    planner
    profile
    reports
    schemaextensions
    security
    users
    usersfunctions

Commands:
    login                  : Log in to Microsoft Graph.
    logout                 : Log out of Microsoft Graph.
#>