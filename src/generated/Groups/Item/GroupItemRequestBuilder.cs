using ApiSdk.Groups.Item.AcceptedSenders;
using ApiSdk.Groups.Item.AppRoleAssignments;
using ApiSdk.Groups.Item.Calendar;
using ApiSdk.Groups.Item.CalendarView;
using ApiSdk.Groups.Item.Conversations;
using ApiSdk.Groups.Item.CreatedOnBehalfOf;
using ApiSdk.Groups.Item.Drive;
using ApiSdk.Groups.Item.Drives;
using ApiSdk.Groups.Item.Events;
using ApiSdk.Groups.Item.Extensions;
using ApiSdk.Groups.Item.GroupLifecyclePolicies;
using ApiSdk.Groups.Item.MemberOf;
using ApiSdk.Groups.Item.Members;
using ApiSdk.Groups.Item.MembersWithLicenseErrors;
using ApiSdk.Groups.Item.MicrosoftGraphAddFavorite;
using ApiSdk.Groups.Item.MicrosoftGraphAssignLicense;
using ApiSdk.Groups.Item.MicrosoftGraphCheckGrantedPermissionsForApp;
using ApiSdk.Groups.Item.MicrosoftGraphCheckMemberGroups;
using ApiSdk.Groups.Item.MicrosoftGraphCheckMemberObjects;
using ApiSdk.Groups.Item.MicrosoftGraphGetMemberGroups;
using ApiSdk.Groups.Item.MicrosoftGraphGetMemberObjects;
using ApiSdk.Groups.Item.MicrosoftGraphRemoveFavorite;
using ApiSdk.Groups.Item.MicrosoftGraphRenew;
using ApiSdk.Groups.Item.MicrosoftGraphResetUnseenCount;
using ApiSdk.Groups.Item.MicrosoftGraphRestore;
using ApiSdk.Groups.Item.MicrosoftGraphSubscribeByMail;
using ApiSdk.Groups.Item.MicrosoftGraphUnsubscribeByMail;
using ApiSdk.Groups.Item.MicrosoftGraphValidateProperties;
using ApiSdk.Groups.Item.Onenote;
using ApiSdk.Groups.Item.Owners;
using ApiSdk.Groups.Item.PermissionGrants;
using ApiSdk.Groups.Item.Photo;
using ApiSdk.Groups.Item.Photos;
using ApiSdk.Groups.Item.Planner;
using ApiSdk.Groups.Item.RejectedSenders;
using ApiSdk.Groups.Item.Settings;
using ApiSdk.Groups.Item.Sites;
using ApiSdk.Groups.Item.Team;
using ApiSdk.Groups.Item.Threads;
using ApiSdk.Groups.Item.TransitiveMemberOf;
using ApiSdk.Groups.Item.TransitiveMembers;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Groups.Item {
    /// <summary>
    /// Provides operations to manage the collection of group entities.
    /// </summary>
    public class GroupItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the acceptedSenders property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildAcceptedSendersCommand() {
            var command = new Command("accepted-senders");
            command.Description = "Provides operations to manage the acceptedSenders property of the microsoft.graph.group entity.";
            var builder = new AcceptedSendersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appRoleAssignments property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            command.Description = "Provides operations to manage the appRoleAssignments property of the microsoft.graph.group entity.";
            var builder = new AppRoleAssignmentsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendar property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.group entity.";
            var builder = new CalendarRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCalendarPermissionsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetScheduleCommand());
            command.AddCommand(builder.BuildMultiValueExtendedPropertiesCommand());
            command.AddCommand(builder.BuildSingleValueExtendedPropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendarView property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildCalendarViewCommand() {
            var command = new Command("calendar-view");
            command.Description = "Provides operations to manage the calendarView property of the microsoft.graph.group entity.";
            var builder = new CalendarViewRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the conversations property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildConversationsCommand() {
            var command = new Command("conversations");
            command.Description = "Provides operations to manage the conversations property of the microsoft.graph.group entity.";
            var builder = new ConversationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the createdOnBehalfOf property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildCreatedOnBehalfOfCommand() {
            var command = new Command("created-on-behalf-of");
            command.Description = "Provides operations to manage the createdOnBehalfOf property of the microsoft.graph.group entity.";
            var builder = new CreatedOnBehalfOfRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Delete group. When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they&apos;re permanently deleted. This isn&apos;t applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see deletedItems.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/group-delete?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete group. When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they're permanently deleted. This isn't applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see deletedItems.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/group-delete?view=graph-rest-1.0";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drive property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.group entity.";
            var builder = new DriveRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.group entity.";
            var builder = new DrivesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the events property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildEventsCommand() {
            var command = new Command("events");
            command.Description = "Provides operations to manage the events property of the microsoft.graph.group entity.";
            var builder = new EventsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.group entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are _not_ returned by default, specify them in a `$select` OData query option. The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/group-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are _not_ returned by default, specify them in a `$select` OData query option. The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/group-get?view=graph-rest-1.0";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the groupLifecyclePolicies property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildGroupLifecyclePoliciesCommand() {
            var command = new Command("group-lifecycle-policies");
            command.Description = "Provides operations to manage the groupLifecyclePolicies property of the microsoft.graph.group entity.";
            var builder = new GroupLifecyclePoliciesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the memberOf property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            command.Description = "Provides operations to manage the memberOf property of the microsoft.graph.group entity.";
            var builder = new MemberOfRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the members property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildMembersCommand() {
            var command = new Command("members");
            command.Description = "Provides operations to manage the members property of the microsoft.graph.group entity.";
            var builder = new MembersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the membersWithLicenseErrors property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildMembersWithLicenseErrorsCommand() {
            var command = new Command("members-with-license-errors");
            command.Description = "Provides operations to manage the membersWithLicenseErrors property of the microsoft.graph.group entity.";
            var builder = new MembersWithLicenseErrorsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the addFavorite method.
        /// </summary>
        public Command BuildMicrosoftGraphAddFavoriteCommand() {
            var command = new Command("microsoft-graph-add-favorite");
            command.Description = "Provides operations to call the addFavorite method.";
            var builder = new MicrosoftGraphAddFavoriteRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the assignLicense method.
        /// </summary>
        public Command BuildMicrosoftGraphAssignLicenseCommand() {
            var command = new Command("microsoft-graph-assign-license");
            command.Description = "Provides operations to call the assignLicense method.";
            var builder = new MicrosoftGraphAssignLicenseRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkGrantedPermissionsForApp method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckGrantedPermissionsForAppCommand() {
            var command = new Command("microsoft-graph-check-granted-permissions-for-app");
            command.Description = "Provides operations to call the checkGrantedPermissionsForApp method.";
            var builder = new MicrosoftGraphCheckGrantedPermissionsForAppRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberGroupsCommand() {
            var command = new Command("microsoft-graph-check-member-groups");
            command.Description = "Provides operations to call the checkMemberGroups method.";
            var builder = new MicrosoftGraphCheckMemberGroupsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberObjectsCommand() {
            var command = new Command("microsoft-graph-check-member-objects");
            command.Description = "Provides operations to call the checkMemberObjects method.";
            var builder = new MicrosoftGraphCheckMemberObjectsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberGroupsCommand() {
            var command = new Command("microsoft-graph-get-member-groups");
            command.Description = "Provides operations to call the getMemberGroups method.";
            var builder = new MicrosoftGraphGetMemberGroupsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberObjectsCommand() {
            var command = new Command("microsoft-graph-get-member-objects");
            command.Description = "Provides operations to call the getMemberObjects method.";
            var builder = new MicrosoftGraphGetMemberObjectsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the removeFavorite method.
        /// </summary>
        public Command BuildMicrosoftGraphRemoveFavoriteCommand() {
            var command = new Command("microsoft-graph-remove-favorite");
            command.Description = "Provides operations to call the removeFavorite method.";
            var builder = new MicrosoftGraphRemoveFavoriteRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the renew method.
        /// </summary>
        public Command BuildMicrosoftGraphRenewCommand() {
            var command = new Command("microsoft-graph-renew");
            command.Description = "Provides operations to call the renew method.";
            var builder = new MicrosoftGraphRenewRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the resetUnseenCount method.
        /// </summary>
        public Command BuildMicrosoftGraphResetUnseenCountCommand() {
            var command = new Command("microsoft-graph-reset-unseen-count");
            command.Description = "Provides operations to call the resetUnseenCount method.";
            var builder = new MicrosoftGraphResetUnseenCountRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the restore method.
        /// </summary>
        public Command BuildMicrosoftGraphRestoreCommand() {
            var command = new Command("microsoft-graph-restore");
            command.Description = "Provides operations to call the restore method.";
            var builder = new MicrosoftGraphRestoreRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the subscribeByMail method.
        /// </summary>
        public Command BuildMicrosoftGraphSubscribeByMailCommand() {
            var command = new Command("microsoft-graph-subscribe-by-mail");
            command.Description = "Provides operations to call the subscribeByMail method.";
            var builder = new MicrosoftGraphSubscribeByMailRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the unsubscribeByMail method.
        /// </summary>
        public Command BuildMicrosoftGraphUnsubscribeByMailCommand() {
            var command = new Command("microsoft-graph-unsubscribe-by-mail");
            command.Description = "Provides operations to call the unsubscribeByMail method.";
            var builder = new MicrosoftGraphUnsubscribeByMailRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the validateProperties method.
        /// </summary>
        public Command BuildMicrosoftGraphValidatePropertiesCommand() {
            var command = new Command("microsoft-graph-validate-properties");
            command.Description = "Provides operations to call the validateProperties method.";
            var builder = new MicrosoftGraphValidatePropertiesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onenote property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.group entity.";
            var builder = new OnenoteRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildNotebooksCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPagesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildResourcesCommand());
            command.AddCommand(builder.BuildSectionGroupsCommand());
            command.AddCommand(builder.BuildSectionsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the owners property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildOwnersCommand() {
            var command = new Command("owners");
            command.Description = "Provides operations to manage the owners property of the microsoft.graph.group entity.";
            var builder = new OwnersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Update the properties of a group object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/group-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a group object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/group-update?view=graph-rest-1.0";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Group>(ApiSdk.Models.Group.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the permissionGrants property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildPermissionGrantsCommand() {
            var command = new Command("permission-grants");
            command.Description = "Provides operations to manage the permissionGrants property of the microsoft.graph.group entity.";
            var builder = new PermissionGrantsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photo property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            command.Description = "Provides operations to manage the photo property of the microsoft.graph.group entity.";
            var builder = new PhotoRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photos property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildPhotosCommand() {
            var command = new Command("photos");
            command.Description = "Provides operations to manage the photos property of the microsoft.graph.group entity.";
            var builder = new PhotosRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the planner property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            command.Description = "Provides operations to manage the planner property of the microsoft.graph.group entity.";
            var builder = new PlannerRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the rejectedSenders property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildRejectedSendersCommand() {
            var command = new Command("rejected-senders");
            command.Description = "Provides operations to manage the rejectedSenders property of the microsoft.graph.group entity.";
            var builder = new RejectedSendersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the settings property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildSettingsCommand() {
            var command = new Command("settings");
            command.Description = "Provides operations to manage the settings property of the microsoft.graph.group entity.";
            var builder = new SettingsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the sites property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            command.Description = "Provides operations to manage the sites property of the microsoft.graph.group entity.";
            var builder = new SitesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRemoveCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the team property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildTeamCommand() {
            var command = new Command("team");
            command.Description = "Provides operations to manage the team property of the microsoft.graph.group entity.";
            var builder = new TeamRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAllChannelsCommand());
            command.AddCommand(builder.BuildChannelsCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGroupCommand());
            command.AddCommand(builder.BuildIncomingChannelsCommand());
            command.AddCommand(builder.BuildInstalledAppsCommand());
            command.AddCommand(builder.BuildMembersCommand());
            command.AddCommand(builder.BuildMicrosoftGraphArchiveCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCloneCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCompleteMigrationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSendActivityNotificationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUnarchiveCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPhotoCommand());
            command.AddCommand(builder.BuildPrimaryChannelCommand());
            command.AddCommand(builder.BuildScheduleCommand());
            command.AddCommand(builder.BuildTagsCommand());
            command.AddCommand(builder.BuildTemplateCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the threads property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildThreadsCommand() {
            var command = new Command("threads");
            command.Description = "Provides operations to manage the threads property of the microsoft.graph.group entity.";
            var builder = new ThreadsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            command.Description = "Provides operations to manage the transitiveMemberOf property of the microsoft.graph.group entity.";
            var builder = new TransitiveMemberOfRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the transitiveMembers property of the microsoft.graph.group entity.
        /// </summary>
        public Command BuildTransitiveMembersCommand() {
            var command = new Command("transitive-members");
            command.Description = "Provides operations to manage the transitiveMembers property of the microsoft.graph.group entity.";
            var builder = new TransitiveMembersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete group. When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they&apos;re permanently deleted. This isn&apos;t applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see deletedItems.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<GroupItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<GroupItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GroupItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are _not_ returned by default, specify them in a `$select` OData query option. The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GroupItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GroupItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GroupItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a group object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GroupItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GroupItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are _not_ returned by default, specify them in a `$select` OData query option. The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
        /// </summary>
        public class GroupItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GroupItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GroupItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GroupItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GroupItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
