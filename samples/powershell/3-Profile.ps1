# Validate the profile command usage - TODO: validate from the installed CLI

# 1. Call profile command without arguments

.\mg profile

# Results

<#
usage: mg profile [-h] {set-cloud,show-clouds,add-cloud,update-cloud,delete-cloud,set-version,show-profile} ...
mg profile: error: the following arguments are required: _subcommand
#>

# TODO: Instead of the error message, an example usage would be more helpful and user friendly
# "try mg profile show-profile"

# 2. Call profile command with help flag

.\mg profile -h

# Results

<#
Group
    mg profile

Commands:
    add-cloud    : Add a custom cloud.
    delete-cloud : Deletes a user defined cloud.
    set-cloud    : Set a cloud.
    set-version  : Set version of graph to use.
    show-clouds  : Show list of supported clouds.
    show-profile : Show profile information.
    update-cloud : Update a user defined cloud.

For more specific examples, use: mg find "mg profile"
#>

# 3. Follow the instructions from ".\mg profile -h" to see more specific examples

.\mg find "mg profile"

# Results

<#
ERROR: mg: 'find' is not in the 'mg' command group. See 'mg --help'.
#>

# TODO: Either add the 'find' command group or delete this message

# 4. Show cloud profiles

.\mg profile show-clouds

# Results

<#
{
  "CHINA": {
    "azure_ad_endpoint": "https://login.chinacloudapi.cn",
    "graph_endpoint": "https://microsoftgraph.chinacloudapi.cn",
    "name": "CHINA"
  },
  "GERMANY": {
    "azure_ad_endpoint": "https://login.microsoftonline.de",
    "graph_endpoint": "https://graph.microsoft.de",
    "name": "GERMANY"
  },
  "PUBLIC": {
    "azure_ad_endpoint": "https://login.microsoftonline.com",
    "graph_endpoint": "https://graph.microsoft.com",
    "name": "PUBLIC"
  },
  "US_GOV_L4": {
    "azure_ad_endpoint": "https://login.microsoftonline.us",
    "graph_endpoint": "https://graph.microsoft.us",
    "name": "US_GOV_L4"
  },
  "US_GOV_L5": {
    "azure_ad_endpoint": "https://login.microsoftonline.us",
    "graph_endpoint": "https://dod-graph.microsoft.us",
    "name": "US_GOV_L5"
  }
}
#>

# 5. Show profile

.\mg profile show-profile

# Result

<#
{
  "cloud": {
    "azure_ad_endpoint": "https://login.microsoftonline.com",
    "graph_endpoint": "https://graph.microsoft.com",
    "name": "PUBLIC"
  },
  "version": "v1.0"
}
#>

# 6. Try to use undefined command

.\mg profile add-profile

# Result

<#
ERROR: mg profile: 'add-profile' is not in the 'mg profile' command group. See 'mg profile --help'.
#>

# 7. Add a user defined cloud without the arguments

.\mg profile add-cloud

# Result

<#
usage: mg profile add-cloud [-h] [--verbose] [--debug] [--only-show-errors] [--output {json,jsonc,yaml,yamlc,table,tsv,none}] [--query JMESPATH] --name NAME --graph-endpoint
                            GRAPH_ENDPOINT --azure-ad-endpoint AZURE_AD_ENDPOINT
mg profile add-cloud: error: the following arguments are required: --name, --graph-endpoint, --azure-ad-endpoint
#>

# 7. Add a user defined cloud with the arguments

.\mg profile add-cloud --name redmond --graph-endpoint https://graph.microsoft.com --azure-ad-endpoint https://login.microsoftonline.com

# Result

<#
Cloud "redmond" added successfully
#>

# 8. Add a duplicate user defined cloud with the arguments and use debug flag

.\mg profile add-cloud --name redmond --graph-endpoint https://graph.microsoft.com --azure-ad-endpoint https://login.microsoftonline.com --debug

# Result

<#
DEBUG: cli.knack.cli: Command arguments: ['profile', 'add-cloud', '--name', 'redmond', '--graph-endpoint', 'https://graph.microsoft.com', '--azure-ad-endpoint', 'https://login.microsoftonline.com', '--debug']
DEBUG: cli.knack.cli: __init__ debug log:
Cannot enable color.
DEBUG: cli.knack.cli: Event: Cli.PreExecute []
DEBUG: cli.knack.cli: Event: CommandParser.OnGlobalArgumentsCreate [<function CLILogging.on_global_arguments at 0x0000016F36A12040>, <function OutputProducer.on_global_arguments at 0x0000016F36B229D0>, <function CLIQuery.on_global_arguments at 0x0000016F36B49040>]
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPreCommandTableCreate []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPreCommandTableTruncate [<function MgCliLogging.init_command_file_logging at 0x0000016F3833F9D0>]
INFO: mg_command_data_logger: command args: profile add-cloud --name {} --graph-endpoint {} --azure-ad-endpoint {} --debug
DEBUG: cli.msgraph.cli.core.mglogging: metadata file logging enabled - writing logs to 'C:\Users\mmainer\.mg\commands'.
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPreArgumentLoad []
DEBUG: cli.knack.cli: Event: CommandLoader.OnLoadArguments []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPostArgumentLoad []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPostCommandTableCreate []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnCommandTableLoaded []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPreParseArgs []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnPostParseArgs [<function OutputProducer.handle_output_argument at 0x0000016F36B22A60>, <function CLIQuery.handle_query_parameter at 0x0000016F36B490D0>]
Cloud "redmond" added successfully
DEBUG: cli.knack.cli: Event: CommandInvoker.OnTransformResult []
DEBUG: cli.knack.cli: Event: CommandInvoker.OnFilterResult []
DEBUG: cli.knack.cli: Event: Cli.SuccessfulExecute []
DEBUG: cli.knack.cli: Event: Cli.PostExecute [<function MgCliLogging.deinit_cmd_metadata_logging at 0x0000016F3833FC10>]
INFO: mg_command_data_logger: exit code: 0
#>

# TODO: this clobbers the existing entry. We should at least notify the user that the existing entry was replaced, if not
# prompt before to confirm that is what they want to do.

# 9. Update user defined cloud

.\mg profile update-cloud --name redmond --graph-endpoint https://graph.microsoft.com --azure-ad-endpoint https://login.microsoftonline.com

# Result

<#
usage: mg profile update-cloud [-h] [--verbose] [--debug] [--only-show-errors] [--output {json,jsonc,yaml,yamlc,table,tsv,none}] [--query JMESPATH] --cloud CLOUD
                               [--name NAME] [--graph-endpoint GRAPH_ENDPOINT] [--azure-ad-endpoint AZURE_AD_ENDPOINT]
mg profile update-cloud: error: the following arguments are required: --cloud
#>

# TODO: update-cloud uses the --cloud argument instead of the --name argument for specifying the cloud to update. 
# add-cloud and delete-cloud uses the --name argument. The cloud parameter shoud be removed and the --name argument used.

.\mg profile update-cloud --cloud redmond --graph-endpoint https://graph.microsoft.com --azure-ad-endpoint https://login.microsoftonline.com

# Result

<#
redmond updated successfully
#>

# TODO: make the output conform to the same style as delete and add: Cloud "redmond" updated successfully

# 10. Delete user defined cloud.

.\mg profile delete-cloud --name redmond

# Result

<#
Cloud "redmond" deleted successfully
#>

# 11. Set cloud

.\mg profile set-cloud --name redmond

# Result

<#
Using cloud: redmond
#>

.\mg profile set-cloud --name Redmond

# Result

<#
ERROR: Cloud Redmond not found. Run "mg profile show-clouds" to see available clouds
#>

# Note: nice instructions.