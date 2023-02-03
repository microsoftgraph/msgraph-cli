using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Item.Activities;
using ApiSdk.Users.Item.AgreementAcceptances;
using ApiSdk.Users.Item.AppRoleAssignments;
using ApiSdk.Users.Item.Authentication;
using ApiSdk.Users.Item.Calendar;
using ApiSdk.Users.Item.CalendarGroups;
using ApiSdk.Users.Item.Calendars;
using ApiSdk.Users.Item.CalendarView;
using ApiSdk.Users.Item.Chats;
using ApiSdk.Users.Item.ContactFolders;
using ApiSdk.Users.Item.Contacts;
using ApiSdk.Users.Item.CreatedObjects;
using ApiSdk.Users.Item.DeviceManagementTroubleshootingEvents;
using ApiSdk.Users.Item.DirectReports;
using ApiSdk.Users.Item.Drive;
using ApiSdk.Users.Item.Drives;
using ApiSdk.Users.Item.Events;
using ApiSdk.Users.Item.Extensions;
using ApiSdk.Users.Item.FollowedSites;
using ApiSdk.Users.Item.InferenceClassification;
using ApiSdk.Users.Item.Insights;
using ApiSdk.Users.Item.JoinedTeams;
using ApiSdk.Users.Item.LicenseDetails;
using ApiSdk.Users.Item.MailFolders;
using ApiSdk.Users.Item.ManagedAppRegistrations;
using ApiSdk.Users.Item.ManagedDevices;
using ApiSdk.Users.Item.Manager;
using ApiSdk.Users.Item.MemberOf;
using ApiSdk.Users.Item.Messages;
using ApiSdk.Users.Item.MicrosoftGraphAssignLicense;
using ApiSdk.Users.Item.MicrosoftGraphChangePassword;
using ApiSdk.Users.Item.MicrosoftGraphCheckMemberGroups;
using ApiSdk.Users.Item.MicrosoftGraphCheckMemberObjects;
using ApiSdk.Users.Item.MicrosoftGraphExportDeviceAndAppManagementData;
using ApiSdk.Users.Item.MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTop;
using ApiSdk.Users.Item.MicrosoftGraphExportPersonalData;
using ApiSdk.Users.Item.MicrosoftGraphFindMeetingTimes;
using ApiSdk.Users.Item.MicrosoftGraphGetMailTips;
using ApiSdk.Users.Item.MicrosoftGraphGetManagedAppDiagnosticStatuses;
using ApiSdk.Users.Item.MicrosoftGraphGetManagedAppPolicies;
using ApiSdk.Users.Item.MicrosoftGraphGetManagedDevicesWithAppFailures;
using ApiSdk.Users.Item.MicrosoftGraphGetMemberGroups;
using ApiSdk.Users.Item.MicrosoftGraphGetMemberObjects;
using ApiSdk.Users.Item.MicrosoftGraphReminderViewWithStartDateTimeWithEndDateTime;
using ApiSdk.Users.Item.MicrosoftGraphRemoveAllDevicesFromManagement;
using ApiSdk.Users.Item.MicrosoftGraphReprocessLicenseAssignment;
using ApiSdk.Users.Item.MicrosoftGraphRestore;
using ApiSdk.Users.Item.MicrosoftGraphRevokeSignInSessions;
using ApiSdk.Users.Item.MicrosoftGraphSendMail;
using ApiSdk.Users.Item.MicrosoftGraphTranslateExchangeIds;
using ApiSdk.Users.Item.MicrosoftGraphWipeManagedAppRegistrationsByDeviceTag;
using ApiSdk.Users.Item.Oauth2PermissionGrants;
using ApiSdk.Users.Item.Onenote;
using ApiSdk.Users.Item.OnlineMeetings;
using ApiSdk.Users.Item.Outlook;
using ApiSdk.Users.Item.OwnedDevices;
using ApiSdk.Users.Item.OwnedObjects;
using ApiSdk.Users.Item.People;
using ApiSdk.Users.Item.Photo;
using ApiSdk.Users.Item.Photos;
using ApiSdk.Users.Item.Planner;
using ApiSdk.Users.Item.Presence;
using ApiSdk.Users.Item.RegisteredDevices;
using ApiSdk.Users.Item.ScopedRoleMemberOf;
using ApiSdk.Users.Item.Settings;
using ApiSdk.Users.Item.Teamwork;
using ApiSdk.Users.Item.Todo;
using ApiSdk.Users.Item.TransitiveMemberOf;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item {
    /// <summary>
    /// Provides operations to manage the collection of user entities.
    /// </summary>
    public class UserItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the activities property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildActivitiesCommand() {
            var command = new Command("activities");
            command.Description = "Provides operations to manage the activities property of the microsoft.graph.user entity.";
            var builder = new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRecentCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAgreementAcceptancesCommand() {
            var command = new Command("agreement-acceptances");
            command.Description = "Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.";
            var builder = new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            command.Description = "Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.";
            var builder = new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the authentication property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAuthenticationCommand() {
            var command = new Command("authentication");
            command.Description = "Provides operations to manage the authentication property of the microsoft.graph.user entity.";
            var builder = new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildEmailMethodsCommand());
            command.AddCommand(builder.BuildFido2MethodsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMethodsCommand());
            command.AddCommand(builder.BuildMicrosoftAuthenticatorMethodsCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPasswordMethodsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPhoneMethodsCommand());
            command.AddCommand(builder.BuildSoftwareOathMethodsCommand());
            command.AddCommand(builder.BuildTemporaryAccessPassMethodsCommand());
            command.AddCommand(builder.BuildWindowsHelloForBusinessMethodsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendar property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.user entity.";
            var builder = new CalendarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCalendarPermissionsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetScheduleCommand());
            command.AddCommand(builder.BuildMultiValueExtendedPropertiesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSingleValueExtendedPropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarGroupsCommand() {
            var command = new Command("calendar-groups");
            command.Description = "Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.";
            var builder = new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendars property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarsCommand() {
            var command = new Command("calendars");
            command.Description = "Provides operations to manage the calendars property of the microsoft.graph.user entity.";
            var builder = new CalendarsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendarView property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarViewCommand() {
            var command = new Command("calendar-view");
            command.Description = "Provides operations to manage the calendarView property of the microsoft.graph.user entity.";
            var builder = new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the chats property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            command.Description = "Provides operations to manage the chats property of the microsoft.graph.user entity.";
            var builder = new ChatsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAllMessagesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contactFolders property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildContactFoldersCommand() {
            var command = new Command("contact-folders");
            command.Description = "Provides operations to manage the contactFolders property of the microsoft.graph.user entity.";
            var builder = new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contacts property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            command.Description = "Provides operations to manage the contacts property of the microsoft.graph.user entity.";
            var builder = new ContactsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the createdObjects property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            command.Description = "Provides operations to manage the createdObjects property of the microsoft.graph.user entity.";
            var builder = new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            return command;
        }
        /// <summary>
        /// Delete user.   When deleted, user resources are moved to a temporary container and can be restored within 30 days.  After that time, they are permanently deleted.  To learn more, see deletedItems.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-delete?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete user.   When deleted, user resources are moved to a temporary container and can be restored within 30 days.  After that time, they are permanently deleted.  To learn more, see deletedItems.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-delete?view=graph-rest-1.0";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDeviceManagementTroubleshootingEventsCommand() {
            var command = new Command("device-management-troubleshooting-events");
            command.Description = "Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.";
            var builder = new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the directReports property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDirectReportsCommand() {
            var command = new Command("direct-reports");
            command.Description = "Provides operations to manage the directReports property of the microsoft.graph.user entity.";
            var builder = new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drive property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.user entity.";
            var builder = new DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.user entity.";
            var builder = new DrivesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the events property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildEventsCommand() {
            var command = new Command("events");
            command.Description = "Provides operations to manage the events property of the microsoft.graph.user entity.";
            var builder = new EventsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.user entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the followedSites property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildFollowedSitesCommand() {
            var command = new Command("followed-sites");
            command.Description = "Provides operations to manage the followedSites property of the microsoft.graph.user entity.";
            var builder = new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the properties and relationships of user object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-get?view=graph-rest-1.0";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildInferenceClassificationCommand() {
            var command = new Command("inference-classification");
            command.Description = "Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.";
            var builder = new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOverridesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the insights property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildInsightsCommand() {
            var command = new Command("insights");
            command.Description = "Provides operations to manage the insights property of the microsoft.graph.user entity.";
            var builder = new InsightsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSharedCommand());
            command.AddCommand(builder.BuildTrendingCommand());
            command.AddCommand(builder.BuildUsedCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildJoinedTeamsCommand() {
            var command = new Command("joined-teams");
            command.Description = "Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.";
            var builder = new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAllMessagesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildLicenseDetailsCommand() {
            var command = new Command("license-details");
            command.Description = "Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.";
            var builder = new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mailFolders property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMailFoldersCommand() {
            var command = new Command("mail-folders");
            command.Description = "Provides operations to manage the mailFolders property of the microsoft.graph.user entity.";
            var builder = new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagedAppRegistrationsCommand() {
            var command = new Command("managed-app-registrations");
            command.Description = "Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.";
            var builder = new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            command.Description = "Provides operations to manage the managedDevices property of the microsoft.graph.user entity.";
            var builder = new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the manager property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagerCommand() {
            var command = new Command("manager");
            command.Description = "Provides operations to manage the manager property of the microsoft.graph.user entity.";
            var builder = new ManagerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the memberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            command.Description = "Provides operations to manage the memberOf property of the microsoft.graph.user entity.";
            var builder = new MemberOfRequestBuilder(PathParameters, RequestAdapter);
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
        /// Provides operations to manage the messages property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMessagesCommand() {
            var command = new Command("messages");
            command.Description = "Provides operations to manage the messages property of the microsoft.graph.user entity.";
            var builder = new MessagesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the assignLicense method.
        /// </summary>
        public Command BuildMicrosoftGraphAssignLicenseCommand() {
            var command = new Command("microsoft-graph-assign-license");
            command.Description = "Provides operations to call the assignLicense method.";
            var builder = new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the changePassword method.
        /// </summary>
        public Command BuildMicrosoftGraphChangePasswordCommand() {
            var command = new Command("microsoft-graph-change-password");
            command.Description = "Provides operations to call the changePassword method.";
            var builder = new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberGroupsCommand() {
            var command = new Command("microsoft-graph-check-member-groups");
            command.Description = "Provides operations to call the checkMemberGroups method.";
            var builder = new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberObjectsCommand() {
            var command = new Command("microsoft-graph-check-member-objects");
            command.Description = "Provides operations to call the checkMemberObjects method.";
            var builder = new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        public Command BuildMicrosoftGraphExportDeviceAndAppManagementDataCommand() {
            var command = new Command("microsoft-graph-export-device-and-app-management-data");
            command.Description = "Provides operations to call the exportDeviceAndAppManagementData method.";
            var builder = new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the exportPersonalData method.
        /// </summary>
        public Command BuildMicrosoftGraphExportPersonalDataCommand() {
            var command = new Command("microsoft-graph-export-personal-data");
            command.Description = "Provides operations to call the exportPersonalData method.";
            var builder = new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the findMeetingTimes method.
        /// </summary>
        public Command BuildMicrosoftGraphFindMeetingTimesCommand() {
            var command = new Command("microsoft-graph-find-meeting-times");
            command.Description = "Provides operations to call the findMeetingTimes method.";
            var builder = new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMailTips method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMailTipsCommand() {
            var command = new Command("microsoft-graph-get-mail-tips");
            command.Description = "Provides operations to call the getMailTips method.";
            var builder = new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedAppDiagnosticStatuses method.
        /// </summary>
        public Command BuildMicrosoftGraphGetManagedAppDiagnosticStatusesCommand() {
            var command = new Command("microsoft-graph-get-managed-app-diagnostic-statuses");
            command.Description = "Provides operations to call the getManagedAppDiagnosticStatuses method.";
            var builder = new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedAppPolicies method.
        /// </summary>
        public Command BuildMicrosoftGraphGetManagedAppPoliciesCommand() {
            var command = new Command("microsoft-graph-get-managed-app-policies");
            command.Description = "Provides operations to call the getManagedAppPolicies method.";
            var builder = new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedDevicesWithAppFailures method.
        /// </summary>
        public Command BuildMicrosoftGraphGetManagedDevicesWithAppFailuresCommand() {
            var command = new Command("microsoft-graph-get-managed-devices-with-app-failures");
            command.Description = "Provides operations to call the getManagedDevicesWithAppFailures method.";
            var builder = new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberGroupsCommand() {
            var command = new Command("microsoft-graph-get-member-groups");
            command.Description = "Provides operations to call the getMemberGroups method.";
            var builder = new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberObjectsCommand() {
            var command = new Command("microsoft-graph-get-member-objects");
            command.Description = "Provides operations to call the getMemberObjects method.";
            var builder = new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the removeAllDevicesFromManagement method.
        /// </summary>
        public Command BuildMicrosoftGraphRemoveAllDevicesFromManagementCommand() {
            var command = new Command("microsoft-graph-remove-all-devices-from-management");
            command.Description = "Provides operations to call the removeAllDevicesFromManagement method.";
            var builder = new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the reprocessLicenseAssignment method.
        /// </summary>
        public Command BuildMicrosoftGraphReprocessLicenseAssignmentCommand() {
            var command = new Command("microsoft-graph-reprocess-license-assignment");
            command.Description = "Provides operations to call the reprocessLicenseAssignment method.";
            var builder = new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the restore method.
        /// </summary>
        public Command BuildMicrosoftGraphRestoreCommand() {
            var command = new Command("microsoft-graph-restore");
            command.Description = "Provides operations to call the restore method.";
            var builder = new RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the revokeSignInSessions method.
        /// </summary>
        public Command BuildMicrosoftGraphRevokeSignInSessionsCommand() {
            var command = new Command("microsoft-graph-revoke-sign-in-sessions");
            command.Description = "Provides operations to call the revokeSignInSessions method.";
            var builder = new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the sendMail method.
        /// </summary>
        public Command BuildMicrosoftGraphSendMailCommand() {
            var command = new Command("microsoft-graph-send-mail");
            command.Description = "Provides operations to call the sendMail method.";
            var builder = new SendMailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the translateExchangeIds method.
        /// </summary>
        public Command BuildMicrosoftGraphTranslateExchangeIdsCommand() {
            var command = new Command("microsoft-graph-translate-exchange-ids");
            command.Description = "Provides operations to call the translateExchangeIds method.";
            var builder = new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.
        /// </summary>
        public Command BuildMicrosoftGraphWipeManagedAppRegistrationsByDeviceTagCommand() {
            var command = new Command("microsoft-graph-wipe-managed-app-registrations-by-device-tag");
            command.Description = "Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.";
            var builder = new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            command.Description = "Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.";
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onenote property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.user entity.";
            var builder = new OnenoteRequestBuilder(PathParameters, RequestAdapter);
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
        /// Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOnlineMeetingsCommand() {
            var command = new Command("online-meetings");
            command.Description = "Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.";
            var builder = new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCreateOrGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the outlook property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOutlookCommand() {
            var command = new Command("outlook");
            command.Description = "Provides operations to manage the outlook property of the microsoft.graph.user entity.";
            var builder = new OutlookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMasterCategoriesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSupportedLanguagesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSupportedTimeZonesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOwnedDevicesCommand() {
            var command = new Command("owned-devices");
            command.Description = "Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.";
            var builder = new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAppRoleAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEndpointCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            command.Description = "Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.";
            var builder = new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            return command;
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-update?view=graph-rest-1.0";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the people property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPeopleCommand() {
            var command = new Command("people");
            command.Description = "Provides operations to manage the people property of the microsoft.graph.user entity.";
            var builder = new PeopleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photo property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            command.Description = "Provides operations to manage the photo property of the microsoft.graph.user entity.";
            var builder = new PhotoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photos property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPhotosCommand() {
            var command = new Command("photos");
            command.Description = "Provides operations to manage the photos property of the microsoft.graph.user entity.";
            var builder = new PhotosRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the planner property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            command.Description = "Provides operations to manage the planner property of the microsoft.graph.user entity.";
            var builder = new PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            command.AddCommand(builder.BuildTasksCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the presence property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPresenceCommand() {
            var command = new Command("presence");
            command.Description = "Provides operations to manage the presence property of the microsoft.graph.user entity.";
            var builder = new PresenceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphClearPresenceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphClearUserPreferredPresenceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSetPresenceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSetUserPreferredPresenceCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildRegisteredDevicesCommand() {
            var command = new Command("registered-devices");
            command.Description = "Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.";
            var builder = new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAppRoleAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEndpointCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildScopedRoleMemberOfCommand() {
            var command = new Command("scoped-role-member-of");
            command.Description = "Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.";
            var builder = new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the settings property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildSettingsCommand() {
            var command = new Command("settings");
            command.Description = "Provides operations to manage the settings property of the microsoft.graph.user entity.";
            var builder = new SettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildShiftPreferencesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the teamwork property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            command.Description = "Provides operations to manage the teamwork property of the microsoft.graph.user entity.";
            var builder = new TeamworkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssociatedTeamsCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInstalledAppsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSendActivityNotificationCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the todo property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTodoCommand() {
            var command = new Command("todo");
            command.Description = "Provides operations to manage the todo property of the microsoft.graph.user entity.";
            var builder = new TodoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildListsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            command.Description = "Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.";
            var builder = new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
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
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTop(int? skip, int? top) {
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(PathParameters, RequestAdapter, skip, top);
        }
        /// <summary>
        /// Provides operations to call the reminderView method.
        /// </summary>
        /// <param name="endDateTime">Usage: EndDateTime=&apos;{EndDateTime}&apos;</param>
        /// <param name="startDateTime">Usage: StartDateTime=&apos;{StartDateTime}&apos;</param>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphReminderViewWithStartDateTimeWithEndDateTime(string endDateTime, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime);
        }
        /// <summary>
        /// Delete user.   When deleted, user resources are moved to a temporary container and can be restored within 30 days.  After that time, they are permanently deleted.  To learn more, see deletedItems.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<UserItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<UserItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object.
        /// </summary>
        public class UserItemRequestBuilderGetQueryParameters {
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
        public class UserItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
