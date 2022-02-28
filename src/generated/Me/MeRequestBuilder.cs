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
using ApiSdk.Me.ExportPersonalData;
using ApiSdk.Me.Extensions;
using ApiSdk.Me.FindMeetingTimes;
using ApiSdk.Me.FollowedSites;
using ApiSdk.Me.GetMailTips;
using ApiSdk.Me.GetManagedAppDiagnosticStatuses;
using ApiSdk.Me.GetManagedAppPolicies;
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
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
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
    /// <summary>Builds and executes requests for operations under \me</summary>
    public class MeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildActivitiesCommand() {
            var command = new Command("activities");
            var builder = new ApiSdk.Me.Activities.ActivitiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAgreementAcceptancesCommand() {
            var command = new Command("agreement-acceptances");
            var builder = new ApiSdk.Me.AgreementAcceptances.AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            var builder = new ApiSdk.Me.AppRoleAssignments.AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAssignLicenseCommand() {
            var command = new Command("assign-license");
            var builder = new ApiSdk.Me.AssignLicense.AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAuthenticationCommand() {
            var command = new Command("authentication");
            var builder = new ApiSdk.Me.Authentication.AuthenticationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFido2MethodsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMethodsCommand());
            command.AddCommand(builder.BuildMicrosoftAuthenticatorMethodsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildWindowsHelloForBusinessMethodsCommand());
            return command;
        }
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            var builder = new ApiSdk.Me.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildCalendarGroupsCommand() {
            var command = new Command("calendar-groups");
            var builder = new ApiSdk.Me.CalendarGroups.CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarsCommand() {
            var command = new Command("calendars");
            var builder = new ApiSdk.Me.Calendars.CalendarsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarViewCommand() {
            var command = new Command("calendar-view");
            var builder = new ApiSdk.Me.CalendarView.CalendarViewRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildChangePasswordCommand() {
            var command = new Command("change-password");
            var builder = new ApiSdk.Me.ChangePassword.ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            var builder = new ApiSdk.Me.Chats.ChatsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCheckMemberGroupsCommand() {
            var command = new Command("check-member-groups");
            var builder = new ApiSdk.Me.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberObjectsCommand() {
            var command = new Command("check-member-objects");
            var builder = new ApiSdk.Me.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildContactFoldersCommand() {
            var command = new Command("contact-folders");
            var builder = new ApiSdk.Me.ContactFolders.ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            var builder = new ApiSdk.Me.Contacts.ContactsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            var builder = new ApiSdk.Me.CreatedObjects.CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildDeviceManagementTroubleshootingEventsCommand() {
            var command = new Command("device-management-troubleshooting-events");
            var builder = new ApiSdk.Me.DeviceManagementTroubleshootingEvents.DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDirectReportsCommand() {
            var command = new Command("direct-reports");
            var builder = new ApiSdk.Me.DirectReports.DirectReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            var builder = new ApiSdk.Me.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            var builder = new ApiSdk.Me.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildEventsCommand() {
            var command = new Command("events");
            var builder = new ApiSdk.Me.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildExportPersonalDataCommand() {
            var command = new Command("export-personal-data");
            var builder = new ApiSdk.Me.ExportPersonalData.ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ApiSdk.Me.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildFindMeetingTimesCommand() {
            var command = new Command("find-meeting-times");
            var builder = new ApiSdk.Me.FindMeetingTimes.FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFollowedSitesCommand() {
            var command = new Command("followed-sites");
            var builder = new ApiSdk.Me.FollowedSites.FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Get me
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get me";
            // Create options for all the parameters
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
            command.SetHandler(async (object[] parameters) => {
                var select = (string[]) parameters[0];
                var expand = (string[]) parameters[1];
                var output = (FormatterType) parameters[2];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildGetMailTipsCommand() {
            var command = new Command("get-mail-tips");
            var builder = new ApiSdk.Me.GetMailTips.GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberGroupsCommand() {
            var command = new Command("get-member-groups");
            var builder = new ApiSdk.Me.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberObjectsCommand() {
            var command = new Command("get-member-objects");
            var builder = new ApiSdk.Me.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildInferenceClassificationCommand() {
            var command = new Command("inference-classification");
            var builder = new ApiSdk.Me.InferenceClassification.InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOverridesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildInsightsCommand() {
            var command = new Command("insights");
            var builder = new ApiSdk.Me.Insights.InsightsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSharedCommand());
            command.AddCommand(builder.BuildTrendingCommand());
            command.AddCommand(builder.BuildUsedCommand());
            return command;
        }
        public Command BuildJoinedTeamsCommand() {
            var command = new Command("joined-teams");
            var builder = new ApiSdk.Me.JoinedTeams.JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildLicenseDetailsCommand() {
            var command = new Command("license-details");
            var builder = new ApiSdk.Me.LicenseDetails.LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMailFoldersCommand() {
            var command = new Command("mail-folders");
            var builder = new ApiSdk.Me.MailFolders.MailFoldersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppRegistrationsCommand() {
            var command = new Command("managed-app-registrations");
            var builder = new ApiSdk.Me.ManagedAppRegistrations.ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            var builder = new ApiSdk.Me.ManagedDevices.ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagerCommand() {
            var command = new Command("manager");
            var builder = new ApiSdk.Me.Manager.ManagerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            var builder = new ApiSdk.Me.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMessagesCommand() {
            var command = new Command("messages");
            var builder = new ApiSdk.Me.Messages.MessagesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new ApiSdk.Me.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            var builder = new ApiSdk.Me.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildOnlineMeetingsCommand() {
            var command = new Command("online-meetings");
            var builder = new ApiSdk.Me.OnlineMeetings.OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildCreateOrGetCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOutlookCommand() {
            var command = new Command("outlook");
            var builder = new ApiSdk.Me.Outlook.OutlookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMasterCategoriesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildOwnedDevicesCommand() {
            var command = new Command("owned-devices");
            var builder = new ApiSdk.Me.OwnedDevices.OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            var builder = new ApiSdk.Me.OwnedObjects.OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Update me
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update me";
            // Create options for all the parameters
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var body = (string) parameters[0];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.User>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildPeopleCommand() {
            var command = new Command("people");
            var builder = new ApiSdk.Me.People.PeopleRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            var builder = new ApiSdk.Me.Photo.PhotoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildPhotosCommand() {
            var command = new Command("photos");
            var builder = new ApiSdk.Me.Photos.PhotosRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            var builder = new ApiSdk.Me.Planner.PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            command.AddCommand(builder.BuildTasksCommand());
            return command;
        }
        public Command BuildPresenceCommand() {
            var command = new Command("presence");
            var builder = new ApiSdk.Me.Presence.PresenceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearPresenceCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSetPresenceCommand());
            return command;
        }
        public Command BuildRegisteredDevicesCommand() {
            var command = new Command("registered-devices");
            var builder = new ApiSdk.Me.RegisteredDevices.RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildRemoveAllDevicesFromManagementCommand() {
            var command = new Command("remove-all-devices-from-management");
            var builder = new ApiSdk.Me.RemoveAllDevicesFromManagement.RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReprocessLicenseAssignmentCommand() {
            var command = new Command("reprocess-license-assignment");
            var builder = new ApiSdk.Me.ReprocessLicenseAssignment.ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new ApiSdk.Me.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRevokeSignInSessionsCommand() {
            var command = new Command("revoke-sign-in-sessions");
            var builder = new ApiSdk.Me.RevokeSignInSessions.RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildScopedRoleMemberOfCommand() {
            var command = new Command("scoped-role-member-of");
            var builder = new ApiSdk.Me.ScopedRoleMemberOf.ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSendMailCommand() {
            var command = new Command("send-mail");
            var builder = new ApiSdk.Me.SendMail.SendMailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSettingsCommand() {
            var command = new Command("settings");
            var builder = new ApiSdk.Me.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildShiftPreferencesCommand());
            return command;
        }
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            var builder = new ApiSdk.Me.Teamwork.TeamworkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInstalledAppsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSendActivityNotificationCommand());
            return command;
        }
        public Command BuildTodoCommand() {
            var command = new Command("todo");
            var builder = new ApiSdk.Me.Todo.TodoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildListsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            var builder = new ApiSdk.Me.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTranslateExchangeIdsCommand() {
            var command = new Command("translate-exchange-ids");
            var builder = new ApiSdk.Me.TranslateExchangeIds.TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWipeManagedAppRegistrationsByDeviceTagCommand() {
            var command = new Command("wipe-managed-app-registrations-by-device-tag");
            var builder = new ApiSdk.Me.WipeManagedAppRegistrationsByDeviceTag.WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get me
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
        /// Update me
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \me\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \me\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \me\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string startDateTime, string endDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime);
        }
        /// <summary>Get me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
