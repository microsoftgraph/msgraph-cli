using ApiSdk.Groups.Item.AcceptedSenders;
using ApiSdk.Groups.Item.AddFavorite;
using ApiSdk.Groups.Item.AppRoleAssignments;
using ApiSdk.Groups.Item.AssignLicense;
using ApiSdk.Groups.Item.Calendar;
using ApiSdk.Groups.Item.CalendarView;
using ApiSdk.Groups.Item.CheckGrantedPermissionsForApp;
using ApiSdk.Groups.Item.CheckMemberGroups;
using ApiSdk.Groups.Item.CheckMemberObjects;
using ApiSdk.Groups.Item.Conversations;
using ApiSdk.Groups.Item.CreatedOnBehalfOf;
using ApiSdk.Groups.Item.Drive;
using ApiSdk.Groups.Item.Drives;
using ApiSdk.Groups.Item.Events;
using ApiSdk.Groups.Item.Extensions;
using ApiSdk.Groups.Item.GetMemberGroups;
using ApiSdk.Groups.Item.GetMemberObjects;
using ApiSdk.Groups.Item.GroupLifecyclePolicies;
using ApiSdk.Groups.Item.MemberOf;
using ApiSdk.Groups.Item.Members;
using ApiSdk.Groups.Item.MembersWithLicenseErrors;
using ApiSdk.Groups.Item.Onenote;
using ApiSdk.Groups.Item.Owners;
using ApiSdk.Groups.Item.PermissionGrants;
using ApiSdk.Groups.Item.Photo;
using ApiSdk.Groups.Item.Photos;
using ApiSdk.Groups.Item.Planner;
using ApiSdk.Groups.Item.RejectedSenders;
using ApiSdk.Groups.Item.RemoveFavorite;
using ApiSdk.Groups.Item.Renew;
using ApiSdk.Groups.Item.ResetUnseenCount;
using ApiSdk.Groups.Item.Restore;
using ApiSdk.Groups.Item.Settings;
using ApiSdk.Groups.Item.Sites;
using ApiSdk.Groups.Item.SubscribeByMail;
using ApiSdk.Groups.Item.Team;
using ApiSdk.Groups.Item.Threads;
using ApiSdk.Groups.Item.TransitiveMemberOf;
using ApiSdk.Groups.Item.TransitiveMembers;
using ApiSdk.Groups.Item.UnsubscribeByMail;
using ApiSdk.Groups.Item.ValidateProperties;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Groups.Item {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}</summary>
    public class GroupRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAcceptedSendersCommand() {
            var command = new Command("accepted-senders");
            var builder = new ApiSdk.Groups.Item.AcceptedSenders.AcceptedSendersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildAddFavoriteCommand() {
            var command = new Command("add-favorite");
            var builder = new ApiSdk.Groups.Item.AddFavorite.AddFavoriteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            var builder = new ApiSdk.Groups.Item.AppRoleAssignments.AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAssignLicenseCommand() {
            var command = new Command("assign-license");
            var builder = new ApiSdk.Groups.Item.AssignLicense.AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            var builder = new ApiSdk.Groups.Item.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCalendarPermissionsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetScheduleCommand());
            command.AddCommand(builder.BuildMultiValueExtendedPropertiesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSingleValueExtendedPropertiesCommand());
            return command;
        }
        public Command BuildCalendarViewCommand() {
            var command = new Command("calendar-view");
            var builder = new ApiSdk.Groups.Item.CalendarView.CalendarViewRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCheckGrantedPermissionsForAppCommand() {
            var command = new Command("check-granted-permissions-for-app");
            var builder = new ApiSdk.Groups.Item.CheckGrantedPermissionsForApp.CheckGrantedPermissionsForAppRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberGroupsCommand() {
            var command = new Command("check-member-groups");
            var builder = new ApiSdk.Groups.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberObjectsCommand() {
            var command = new Command("check-member-objects");
            var builder = new ApiSdk.Groups.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConversationsCommand() {
            var command = new Command("conversations");
            var builder = new ApiSdk.Groups.Item.Conversations.ConversationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCreatedOnBehalfOfCommand() {
            var command = new Command("created-on-behalf-of");
            var builder = new ApiSdk.Groups.Item.CreatedOnBehalfOf.CreatedOnBehalfOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from groups
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            command.SetHandler(async (string groupId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, groupIdOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            var builder = new ApiSdk.Groups.Item.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            var builder = new ApiSdk.Groups.Item.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildEventsCommand() {
            var command = new Command("events");
            var builder = new ApiSdk.Groups.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ApiSdk.Groups.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Get entity from groups by key
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get entity from groups by key";
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
            command.SetHandler(async (string groupId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, groupIdOption, selectOption, expandOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildGetMemberGroupsCommand() {
            var command = new Command("get-member-groups");
            var builder = new ApiSdk.Groups.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberObjectsCommand() {
            var command = new Command("get-member-objects");
            var builder = new ApiSdk.Groups.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGroupLifecyclePoliciesCommand() {
            var command = new Command("group-lifecycle-policies");
            var builder = new ApiSdk.Groups.Item.GroupLifecyclePolicies.GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            var builder = new ApiSdk.Groups.Item.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMembersCommand() {
            var command = new Command("members");
            var builder = new ApiSdk.Groups.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMembersWithLicenseErrorsCommand() {
            var command = new Command("members-with-license-errors");
            var builder = new ApiSdk.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            var builder = new ApiSdk.Groups.Item.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildOwnersCommand() {
            var command = new Command("owners");
            var builder = new ApiSdk.Groups.Item.Owners.OwnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Update entity in groups
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string groupId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Group>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, groupIdOption, bodyOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildPermissionGrantsCommand() {
            var command = new Command("permission-grants");
            var builder = new ApiSdk.Groups.Item.PermissionGrants.PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            var builder = new ApiSdk.Groups.Item.Photo.PhotoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildPhotosCommand() {
            var command = new Command("photos");
            var builder = new ApiSdk.Groups.Item.Photos.PhotosRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            var builder = new ApiSdk.Groups.Item.Planner.PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            return command;
        }
        public Command BuildRejectedSendersCommand() {
            var command = new Command("rejected-senders");
            var builder = new ApiSdk.Groups.Item.RejectedSenders.RejectedSendersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildRemoveFavoriteCommand() {
            var command = new Command("remove-favorite");
            var builder = new ApiSdk.Groups.Item.RemoveFavorite.RemoveFavoriteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRenewCommand() {
            var command = new Command("renew");
            var builder = new ApiSdk.Groups.Item.Renew.RenewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildResetUnseenCountCommand() {
            var command = new Command("reset-unseen-count");
            var builder = new ApiSdk.Groups.Item.ResetUnseenCount.ResetUnseenCountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new ApiSdk.Groups.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSettingsCommand() {
            var command = new Command("settings");
            var builder = new ApiSdk.Groups.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            var builder = new ApiSdk.Groups.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSubscribeByMailCommand() {
            var command = new Command("subscribe-by-mail");
            var builder = new ApiSdk.Groups.Item.SubscribeByMail.SubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTeamCommand() {
            var command = new Command("team");
            var builder = new ApiSdk.Groups.Item.Team.TeamRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildThreadsCommand() {
            var command = new Command("threads");
            var builder = new ApiSdk.Groups.Item.Threads.ThreadsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            var builder = new ApiSdk.Groups.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTransitiveMembersCommand() {
            var command = new Command("transitive-members");
            var builder = new ApiSdk.Groups.Item.TransitiveMembers.TransitiveMembersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildUnsubscribeByMailCommand() {
            var command = new Command("unsubscribe-by-mail");
            var builder = new ApiSdk.Groups.Item.UnsubscribeByMail.UnsubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildValidatePropertiesCommand() {
            var command = new Command("validate-properties");
            var builder = new ApiSdk.Groups.Item.ValidateProperties.ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GroupRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GroupRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from groups
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from groups by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update entity in groups
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from groups
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Get entity from groups by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Group> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Group>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update entity in groups
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Group model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get entity from groups by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
