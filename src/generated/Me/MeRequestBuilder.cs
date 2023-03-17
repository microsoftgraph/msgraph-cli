using ApiSdk.Me.Activities;
using ApiSdk.Me.AgreementAcceptances;
using ApiSdk.Me.AppRoleAssignments;
using ApiSdk.Me.AssignLicense;
using ApiSdk.Me.Authentication;
using ApiSdk.Me.Calendar;
using ApiSdk.Me.CalendarGroups;
using ApiSdk.Me.Calendars;
using ApiSdk.Me.CalendarView;
using ApiSdk.Me.ChangePassword;
using ApiSdk.Me.Chats;
using ApiSdk.Me.CheckMemberGroups;
using ApiSdk.Me.CheckMemberObjects;
using ApiSdk.Me.ContactFolders;
using ApiSdk.Me.Contacts;
using ApiSdk.Me.CreatedObjects;
using ApiSdk.Me.DeviceManagementTroubleshootingEvents;
using ApiSdk.Me.DirectReports;
using ApiSdk.Me.Drive;
using ApiSdk.Me.Drives;
using ApiSdk.Me.Events;
using ApiSdk.Me.ExportDeviceAndAppManagementData;
using ApiSdk.Me.ExportDeviceAndAppManagementDataWithSkipWithTop;
using ApiSdk.Me.ExportPersonalData;
using ApiSdk.Me.Extensions;
using ApiSdk.Me.FindMeetingTimes;
using ApiSdk.Me.FollowedSites;
using ApiSdk.Me.GetMailTips;
using ApiSdk.Me.GetManagedAppDiagnosticStatuses;
using ApiSdk.Me.GetManagedAppPolicies;
using ApiSdk.Me.GetManagedDevicesWithAppFailures;
using ApiSdk.Me.GetMemberGroups;
using ApiSdk.Me.GetMemberObjects;
using ApiSdk.Me.InferenceClassification;
using ApiSdk.Me.Insights;
using ApiSdk.Me.JoinedTeams;
using ApiSdk.Me.LicenseDetails;
using ApiSdk.Me.MailFolders;
using ApiSdk.Me.ManagedAppRegistrations;
using ApiSdk.Me.ManagedDevices;
using ApiSdk.Me.Manager;
using ApiSdk.Me.MemberOf;
using ApiSdk.Me.Messages;
using ApiSdk.Me.Oauth2PermissionGrants;
using ApiSdk.Me.Onenote;
using ApiSdk.Me.OnlineMeetings;
using ApiSdk.Me.Outlook;
using ApiSdk.Me.OwnedDevices;
using ApiSdk.Me.OwnedObjects;
using ApiSdk.Me.People;
using ApiSdk.Me.Photo;
using ApiSdk.Me.Photos;
using ApiSdk.Me.Planner;
using ApiSdk.Me.Presence;
using ApiSdk.Me.RegisteredDevices;
using ApiSdk.Me.ReminderViewWithStartDateTimeWithEndDateTime;
using ApiSdk.Me.RemoveAllDevicesFromManagement;
using ApiSdk.Me.ReprocessLicenseAssignment;
using ApiSdk.Me.Restore;
using ApiSdk.Me.RevokeSignInSessions;
using ApiSdk.Me.ScopedRoleMemberOf;
using ApiSdk.Me.SendMail;
using ApiSdk.Me.Settings;
using ApiSdk.Me.Teamwork;
using ApiSdk.Me.Todo;
using ApiSdk.Me.TransitiveMemberOf;
using ApiSdk.Me.TranslateExchangeIds;
using ApiSdk.Me.WipeManagedAppRegistrationsByDeviceTag;
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
namespace ApiSdk.Me {
    /// <summary>
    /// Provides operations to manage the user singleton.
    /// </summary>
    public class MeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the activities property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildActivitiesNavCommand() {
            var command = new Command("activities");
            command.Description = "Provides operations to manage the activities property of the microsoft.graph.user entity.";
            var builder = new ActivitiesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRecentNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAgreementAcceptancesNavCommand() {
            var command = new Command("agreement-acceptances");
            command.Description = "Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.";
            var builder = new AgreementAcceptancesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAppRoleAssignmentsNavCommand() {
            var command = new Command("app-role-assignments");
            command.Description = "Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.";
            var builder = new AppRoleAssignmentsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the assignLicense method.
        /// </summary>
        public Command BuildAssignLicenseNavCommand() {
            var command = new Command("assign-license");
            command.Description = "Provides operations to call the assignLicense method.";
            var builder = new AssignLicenseRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the authentication property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildAuthenticationNavCommand() {
            var command = new Command("authentication");
            command.Description = "Provides operations to manage the authentication property of the microsoft.graph.user entity.";
            var builder = new AuthenticationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildEmailMethodsNavCommand());
            command.AddCommand(builder.BuildFido2MethodsNavCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMethodsNavCommand());
            command.AddCommand(builder.BuildMicrosoftAuthenticatorMethodsNavCommand());
            command.AddCommand(builder.BuildOperationsNavCommand());
            command.AddCommand(builder.BuildPasswordMethodsNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPhoneMethodsNavCommand());
            command.AddCommand(builder.BuildSoftwareOathMethodsNavCommand());
            command.AddCommand(builder.BuildTemporaryAccessPassMethodsNavCommand());
            command.AddCommand(builder.BuildWindowsHelloForBusinessMethodsNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarGroupsNavCommand() {
            var command = new Command("calendar-groups");
            command.Description = "Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.";
            var builder = new CalendarGroupsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendar property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarNavCommand() {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.user entity.";
            var builder = new CalendarRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCalendarPermissionsNavCommand());
            command.AddCommand(builder.BuildCalendarViewNavCommand());
            command.AddCommand(builder.BuildEventsNavCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetScheduleNavCommand());
            command.AddCommand(builder.BuildMultiValueExtendedPropertiesNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSingleValueExtendedPropertiesNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendars property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarsNavCommand() {
            var command = new Command("calendars");
            command.Description = "Provides operations to manage the calendars property of the microsoft.graph.user entity.";
            var builder = new CalendarsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendarView property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCalendarViewNavCommand() {
            var command = new Command("calendar-view");
            command.Description = "Provides operations to manage the calendarView property of the microsoft.graph.user entity.";
            var builder = new CalendarViewRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the changePassword method.
        /// </summary>
        public Command BuildChangePasswordNavCommand() {
            var command = new Command("change-password");
            command.Description = "Provides operations to call the changePassword method.";
            var builder = new ChangePasswordRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the chats property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildChatsNavCommand() {
            var command = new Command("chats");
            command.Description = "Provides operations to manage the chats property of the microsoft.graph.user entity.";
            var builder = new ChatsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAllMessagesNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberGroups method.
        /// </summary>
        public Command BuildCheckMemberGroupsNavCommand() {
            var command = new Command("check-member-groups");
            command.Description = "Provides operations to call the checkMemberGroups method.";
            var builder = new CheckMemberGroupsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberObjects method.
        /// </summary>
        public Command BuildCheckMemberObjectsNavCommand() {
            var command = new Command("check-member-objects");
            command.Description = "Provides operations to call the checkMemberObjects method.";
            var builder = new CheckMemberObjectsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contactFolders property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildContactFoldersNavCommand() {
            var command = new Command("contact-folders");
            command.Description = "Provides operations to manage the contactFolders property of the microsoft.graph.user entity.";
            var builder = new ContactFoldersRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contacts property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildContactsNavCommand() {
            var command = new Command("contacts");
            command.Description = "Provides operations to manage the contacts property of the microsoft.graph.user entity.";
            var builder = new ContactsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the createdObjects property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCreatedObjectsNavCommand() {
            var command = new Command("created-objects");
            command.Description = "Provides operations to manage the createdObjects property of the microsoft.graph.user entity.";
            var builder = new CreatedObjectsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphServicePrincipalNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDeviceManagementTroubleshootingEventsNavCommand() {
            var command = new Command("device-management-troubleshooting-events");
            command.Description = "Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.";
            var builder = new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the directReports property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDirectReportsNavCommand() {
            var command = new Command("direct-reports");
            command.Description = "Provides operations to manage the directReports property of the microsoft.graph.user entity.";
            var builder = new DirectReportsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphOrgContactNavCommand());
            command.AddCommand(builder.BuildGraphUserNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drive property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDriveNavCommand() {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.user entity.";
            var builder = new DriveRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildDrivesNavCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.user entity.";
            var builder = new DrivesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the events property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildEventsNavCommand() {
            var command = new Command("events");
            command.Description = "Provides operations to manage the events property of the microsoft.graph.user entity.";
            var builder = new EventsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        public Command BuildExportDeviceAndAppManagementDataNavCommand() {
            var command = new Command("export-device-and-app-management-data");
            command.Description = "Provides operations to call the exportDeviceAndAppManagementData method.";
            var builder = new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the exportPersonalData method.
        /// </summary>
        public Command BuildExportPersonalDataNavCommand() {
            var command = new Command("export-personal-data");
            command.Description = "Provides operations to call the exportPersonalData method.";
            var builder = new ExportPersonalDataRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildExtensionsNavCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.user entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the findMeetingTimes method.
        /// </summary>
        public Command BuildFindMeetingTimesNavCommand() {
            var command = new Command("find-meeting-times");
            command.Description = "Provides operations to call the findMeetingTimes method.";
            var builder = new FindMeetingTimesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the followedSites property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildFollowedSitesNavCommand() {
            var command = new Command("followed-sites");
            command.Description = "Provides operations to manage the followedSites property of the microsoft.graph.user entity.";
            var builder = new FollowedSitesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Returns the user or organizational contact assigned as the user&apos;s manager. Optionally, you can expand the manager&apos;s chain up to the root node.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-list-manager?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Returns the user or organizational contact assigned as the user's manager. Optionally, you can expand the manager's chain up to the root node.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-list-manager?view=graph-rest-1.0";
            // Create options for all the parameters
            var consistencyLevelOption = new Option<string[]>("--consistency-level", description: "Indicates the requested consistency level. Documentation URL: https://docs.microsoft.com/graph/aad-advanced-queries") {
                Arity = ArgumentArity.ZeroOrMore
            };
            consistencyLevelOption.IsRequired = false;
            command.AddOption(consistencyLevelOption);
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
                var consistencyLevel = invocationContext.ParseResult.GetValueForOption(consistencyLevelOption);
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
                if (consistencyLevel is not null) requestInfo.Headers.Add("ConsistencyLevel", consistencyLevel);
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
        /// Provides operations to call the getMailTips method.
        /// </summary>
        public Command BuildGetMailTipsNavCommand() {
            var command = new Command("get-mail-tips");
            command.Description = "Provides operations to call the getMailTips method.";
            var builder = new GetMailTipsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedAppDiagnosticStatuses method.
        /// </summary>
        public Command BuildGetManagedAppDiagnosticStatusesNavCommand() {
            var command = new Command("get-managed-app-diagnostic-statuses");
            command.Description = "Provides operations to call the getManagedAppDiagnosticStatuses method.";
            var builder = new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedAppPolicies method.
        /// </summary>
        public Command BuildGetManagedAppPoliciesNavCommand() {
            var command = new Command("get-managed-app-policies");
            command.Description = "Provides operations to call the getManagedAppPolicies method.";
            var builder = new GetManagedAppPoliciesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getManagedDevicesWithAppFailures method.
        /// </summary>
        public Command BuildGetManagedDevicesWithAppFailuresNavCommand() {
            var command = new Command("get-managed-devices-with-app-failures");
            command.Description = "Provides operations to call the getManagedDevicesWithAppFailures method.";
            var builder = new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberGroups method.
        /// </summary>
        public Command BuildGetMemberGroupsNavCommand() {
            var command = new Command("get-member-groups");
            command.Description = "Provides operations to call the getMemberGroups method.";
            var builder = new GetMemberGroupsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberObjects method.
        /// </summary>
        public Command BuildGetMemberObjectsNavCommand() {
            var command = new Command("get-member-objects");
            command.Description = "Provides operations to call the getMemberObjects method.";
            var builder = new GetMemberObjectsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildInferenceClassificationNavCommand() {
            var command = new Command("inference-classification");
            command.Description = "Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.";
            var builder = new InferenceClassificationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOverridesNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the insights property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildInsightsNavCommand() {
            var command = new Command("insights");
            command.Description = "Provides operations to manage the insights property of the microsoft.graph.user entity.";
            var builder = new InsightsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSharedNavCommand());
            command.AddCommand(builder.BuildTrendingNavCommand());
            command.AddCommand(builder.BuildUsedNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildJoinedTeamsNavCommand() {
            var command = new Command("joined-teams");
            command.Description = "Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.";
            var builder = new JoinedTeamsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAllMessagesNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildLicenseDetailsNavCommand() {
            var command = new Command("license-details");
            command.Description = "Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.";
            var builder = new LicenseDetailsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mailFolders property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMailFoldersNavCommand() {
            var command = new Command("mail-folders");
            command.Description = "Provides operations to manage the mailFolders property of the microsoft.graph.user entity.";
            var builder = new MailFoldersRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagedAppRegistrationsNavCommand() {
            var command = new Command("managed-app-registrations");
            command.Description = "Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.";
            var builder = new ManagedAppRegistrationsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagedDevicesNavCommand() {
            var command = new Command("managed-devices");
            command.Description = "Provides operations to manage the managedDevices property of the microsoft.graph.user entity.";
            var builder = new ManagedDevicesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the manager property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildManagerNavCommand() {
            var command = new Command("manager");
            command.Description = "Provides operations to manage the manager property of the microsoft.graph.user entity.";
            var builder = new ManagerRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the memberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMemberOfNavCommand() {
            var command = new Command("member-of");
            command.Description = "Provides operations to manage the memberOf property of the microsoft.graph.user entity.";
            var builder = new MemberOfRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphGroupNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the messages property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildMessagesNavCommand() {
            var command = new Command("messages");
            command.Description = "Provides operations to manage the messages property of the microsoft.graph.user entity.";
            var builder = new MessagesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOauth2PermissionGrantsNavCommand() {
            var command = new Command("oauth2-permission-grants");
            command.Description = "Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.";
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onenote property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOnenoteNavCommand() {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.user entity.";
            var builder = new OnenoteRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildNotebooksNavCommand());
            command.AddCommand(builder.BuildOperationsNavCommand());
            command.AddCommand(builder.BuildPagesNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildResourcesNavCommand());
            command.AddCommand(builder.BuildSectionGroupsNavCommand());
            command.AddCommand(builder.BuildSectionsNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOnlineMeetingsNavCommand() {
            var command = new Command("online-meetings");
            command.Description = "Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.";
            var builder = new OnlineMeetingsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildCreateOrGetNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the outlook property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOutlookNavCommand() {
            var command = new Command("outlook");
            command.Description = "Provides operations to manage the outlook property of the microsoft.graph.user entity.";
            var builder = new OutlookRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMasterCategoriesNavCommand());
            command.AddCommand(builder.BuildSupportedLanguagesNavCommand());
            command.AddCommand(builder.BuildSupportedTimeZonesNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOwnedDevicesNavCommand() {
            var command = new Command("owned-devices");
            command.Description = "Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.";
            var builder = new OwnedDevicesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphAppRoleAssignmentNavCommand());
            command.AddCommand(builder.BuildGraphDeviceNavCommand());
            command.AddCommand(builder.BuildGraphEndpointNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildOwnedObjectsNavCommand() {
            var command = new Command("owned-objects");
            command.Description = "Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.";
            var builder = new OwnedObjectsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphApplicationNavCommand());
            command.AddCommand(builder.BuildGraphGroupNavCommand());
            command.AddCommand(builder.BuildGraphServicePrincipalNavCommand());
            command.AddCommand(builder.BuildListCommand());
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
                var model = parseNode.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Provides operations to manage the people property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPeopleNavCommand() {
            var command = new Command("people");
            command.Description = "Provides operations to manage the people property of the microsoft.graph.user entity.";
            var builder = new PeopleRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photo property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPhotoNavCommand() {
            var command = new Command("photo");
            command.Description = "Provides operations to manage the photo property of the microsoft.graph.user entity.";
            var builder = new PhotoRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildContentNavCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the photos property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPhotosNavCommand() {
            var command = new Command("photos");
            command.Description = "Provides operations to manage the photos property of the microsoft.graph.user entity.";
            var builder = new PhotosRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the planner property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPlannerNavCommand() {
            var command = new Command("planner");
            command.Description = "Provides operations to manage the planner property of the microsoft.graph.user entity.";
            var builder = new PlannerRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansNavCommand());
            command.AddCommand(builder.BuildTasksNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the presence property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildPresenceNavCommand() {
            var command = new Command("presence");
            command.Description = "Provides operations to manage the presence property of the microsoft.graph.user entity.";
            var builder = new PresenceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildClearPresenceNavCommand());
            command.AddCommand(builder.BuildClearUserPreferredPresenceNavCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSetPresenceNavCommand());
            command.AddCommand(builder.BuildSetUserPreferredPresenceNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildRegisteredDevicesNavCommand() {
            var command = new Command("registered-devices");
            command.Description = "Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.";
            var builder = new RegisteredDevicesRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphAppRoleAssignmentNavCommand());
            command.AddCommand(builder.BuildGraphDeviceNavCommand());
            command.AddCommand(builder.BuildGraphEndpointNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the removeAllDevicesFromManagement method.
        /// </summary>
        public Command BuildRemoveAllDevicesFromManagementNavCommand() {
            var command = new Command("remove-all-devices-from-management");
            command.Description = "Provides operations to call the removeAllDevicesFromManagement method.";
            var builder = new RemoveAllDevicesFromManagementRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the reprocessLicenseAssignment method.
        /// </summary>
        public Command BuildReprocessLicenseAssignmentNavCommand() {
            var command = new Command("reprocess-license-assignment");
            command.Description = "Provides operations to call the reprocessLicenseAssignment method.";
            var builder = new ReprocessLicenseAssignmentRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the restore method.
        /// </summary>
        public Command BuildRestoreNavCommand() {
            var command = new Command("restore");
            command.Description = "Provides operations to call the restore method.";
            var builder = new RestoreRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the revokeSignInSessions method.
        /// </summary>
        public Command BuildRevokeSignInSessionsNavCommand() {
            var command = new Command("revoke-sign-in-sessions");
            command.Description = "Provides operations to call the revokeSignInSessions method.";
            var builder = new RevokeSignInSessionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildScopedRoleMemberOfNavCommand() {
            var command = new Command("scoped-role-member-of");
            command.Description = "Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.";
            var builder = new ScopedRoleMemberOfRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the sendMail method.
        /// </summary>
        public Command BuildSendMailNavCommand() {
            var command = new Command("send-mail");
            command.Description = "Provides operations to call the sendMail method.";
            var builder = new SendMailRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the settings property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildSettingsNavCommand() {
            var command = new Command("settings");
            command.Description = "Provides operations to manage the settings property of the microsoft.graph.user entity.";
            var builder = new SettingsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildShiftPreferencesNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the teamwork property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTeamworkNavCommand() {
            var command = new Command("teamwork");
            command.Description = "Provides operations to manage the teamwork property of the microsoft.graph.user entity.";
            var builder = new TeamworkRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAssociatedTeamsNavCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInstalledAppsNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSendActivityNotificationNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the todo property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTodoNavCommand() {
            var command = new Command("todo");
            command.Description = "Provides operations to manage the todo property of the microsoft.graph.user entity.";
            var builder = new TodoRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildListsNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildTransitiveMemberOfNavCommand() {
            var command = new Command("transitive-member-of");
            command.Description = "Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.";
            var builder = new TransitiveMemberOfRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildGraphGroupNavCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the translateExchangeIds method.
        /// </summary>
        public Command BuildTranslateExchangeIdsNavCommand() {
            var command = new Command("translate-exchange-ids");
            command.Description = "Provides operations to call the translateExchangeIds method.";
            var builder = new TranslateExchangeIdsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.
        /// </summary>
        public Command BuildWipeManagedAppRegistrationsByDeviceTagNavCommand() {
            var command = new Command("wipe-managed-app-registrations-by-device-tag");
            command.Description = "Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.";
            var builder = new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MeRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Returns the user or organizational contact assigned as the user&apos;s manager. Optionally, you can expand the manager&apos;s chain up to the root node.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MeRequestBuilderGetRequestConfiguration();
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
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.User body, Action<MeRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.User body, Action<MeRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MeRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns the user or organizational contact assigned as the user&apos;s manager. Optionally, you can expand the manager&apos;s chain up to the root node.
        /// </summary>
        public class MeRequestBuilderGetQueryParameters {
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
        public class MeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MeRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MeRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new meRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MeRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new meRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public MeRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
