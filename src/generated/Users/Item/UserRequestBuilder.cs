using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Activities;
using ApiSdk.Users.Item.AgreementAcceptances;
using ApiSdk.Users.Item.AppRoleAssignments;
using ApiSdk.Users.Item.AssignLicense;
using ApiSdk.Users.Item.Authentication;
using ApiSdk.Users.Item.Calendar;
using ApiSdk.Users.Item.CalendarGroups;
using ApiSdk.Users.Item.Calendars;
using ApiSdk.Users.Item.CalendarView;
using ApiSdk.Users.Item.ChangePassword;
using ApiSdk.Users.Item.Chats;
using ApiSdk.Users.Item.CheckMemberGroups;
using ApiSdk.Users.Item.CheckMemberObjects;
using ApiSdk.Users.Item.ContactFolders;
using ApiSdk.Users.Item.Contacts;
using ApiSdk.Users.Item.CreatedObjects;
using ApiSdk.Users.Item.DeviceManagementTroubleshootingEvents;
using ApiSdk.Users.Item.DirectReports;
using ApiSdk.Users.Item.Drive;
using ApiSdk.Users.Item.Drives;
using ApiSdk.Users.Item.Events;
using ApiSdk.Users.Item.ExportPersonalData;
using ApiSdk.Users.Item.Extensions;
using ApiSdk.Users.Item.FindMeetingTimes;
using ApiSdk.Users.Item.FollowedSites;
using ApiSdk.Users.Item.GetMailTips;
using ApiSdk.Users.Item.GetManagedAppDiagnosticStatuses;
using ApiSdk.Users.Item.GetManagedAppPolicies;
using ApiSdk.Users.Item.GetMemberGroups;
using ApiSdk.Users.Item.GetMemberObjects;
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
using ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime;
using ApiSdk.Users.Item.RemoveAllDevicesFromManagement;
using ApiSdk.Users.Item.ReprocessLicenseAssignment;
using ApiSdk.Users.Item.Restore;
using ApiSdk.Users.Item.RevokeSignInSessions;
using ApiSdk.Users.Item.ScopedRoleMemberOf;
using ApiSdk.Users.Item.SendMail;
using ApiSdk.Users.Item.Settings;
using ApiSdk.Users.Item.Teamwork;
using ApiSdk.Users.Item.Todo;
using ApiSdk.Users.Item.TransitiveMemberOf;
using ApiSdk.Users.Item.TranslateExchangeIds;
using ApiSdk.Users.Item.WipeManagedAppRegistrationsByDeviceTag;
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
namespace ApiSdk.Users.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}</summary>
    public class UserRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildActivitiesCommand() {
            var command = new Command("activities");
            var builder = new ApiSdk.Users.Item.Activities.ActivitiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAgreementAcceptancesCommand() {
            var command = new Command("agreement-acceptances");
            var builder = new ApiSdk.Users.Item.AgreementAcceptances.AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            var builder = new ApiSdk.Users.Item.AppRoleAssignments.AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAssignLicenseCommand() {
            var command = new Command("assign-license");
            var builder = new ApiSdk.Users.Item.AssignLicense.AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAuthenticationCommand() {
            var command = new Command("authentication");
            var builder = new ApiSdk.Users.Item.Authentication.AuthenticationRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ApiSdk.Users.Item.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ApiSdk.Users.Item.CalendarGroups.CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarsCommand() {
            var command = new Command("calendars");
            var builder = new ApiSdk.Users.Item.Calendars.CalendarsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarViewCommand() {
            var command = new Command("calendar-view");
            var builder = new ApiSdk.Users.Item.CalendarView.CalendarViewRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildChangePasswordCommand() {
            var command = new Command("change-password");
            var builder = new ApiSdk.Users.Item.ChangePassword.ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            var builder = new ApiSdk.Users.Item.Chats.ChatsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCheckMemberGroupsCommand() {
            var command = new Command("check-member-groups");
            var builder = new ApiSdk.Users.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberObjectsCommand() {
            var command = new Command("check-member-objects");
            var builder = new ApiSdk.Users.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildContactFoldersCommand() {
            var command = new Command("contact-folders");
            var builder = new ApiSdk.Users.Item.ContactFolders.ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            var builder = new ApiSdk.Users.Item.Contacts.ContactsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            var builder = new ApiSdk.Users.Item.CreatedObjects.CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from users
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            command.SetHandler(async (string userId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, userIdOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildDeviceManagementTroubleshootingEventsCommand() {
            var command = new Command("device-management-troubleshooting-events");
            var builder = new ApiSdk.Users.Item.DeviceManagementTroubleshootingEvents.DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDirectReportsCommand() {
            var command = new Command("direct-reports");
            var builder = new ApiSdk.Users.Item.DirectReports.DirectReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            var builder = new ApiSdk.Users.Item.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            var builder = new ApiSdk.Users.Item.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildEventsCommand() {
            var command = new Command("events");
            var builder = new ApiSdk.Users.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildExportPersonalDataCommand() {
            var command = new Command("export-personal-data");
            var builder = new ApiSdk.Users.Item.ExportPersonalData.ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ApiSdk.Users.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildFindMeetingTimesCommand() {
            var command = new Command("find-meeting-times");
            var builder = new ApiSdk.Users.Item.FindMeetingTimes.FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFollowedSitesCommand() {
            var command = new Command("followed-sites");
            var builder = new ApiSdk.Users.Item.FollowedSites.FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Get entity from users by key
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get entity from users by key";
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
            command.SetHandler(async (string userId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, userIdOption, selectOption, expandOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildGetMailTipsCommand() {
            var command = new Command("get-mail-tips");
            var builder = new ApiSdk.Users.Item.GetMailTips.GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberGroupsCommand() {
            var command = new Command("get-member-groups");
            var builder = new ApiSdk.Users.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberObjectsCommand() {
            var command = new Command("get-member-objects");
            var builder = new ApiSdk.Users.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildInferenceClassificationCommand() {
            var command = new Command("inference-classification");
            var builder = new ApiSdk.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOverridesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildInsightsCommand() {
            var command = new Command("insights");
            var builder = new ApiSdk.Users.Item.Insights.InsightsRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ApiSdk.Users.Item.JoinedTeams.JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildLicenseDetailsCommand() {
            var command = new Command("license-details");
            var builder = new ApiSdk.Users.Item.LicenseDetails.LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMailFoldersCommand() {
            var command = new Command("mail-folders");
            var builder = new ApiSdk.Users.Item.MailFolders.MailFoldersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppRegistrationsCommand() {
            var command = new Command("managed-app-registrations");
            var builder = new ApiSdk.Users.Item.ManagedAppRegistrations.ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            var builder = new ApiSdk.Users.Item.ManagedDevices.ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagerCommand() {
            var command = new Command("manager");
            var builder = new ApiSdk.Users.Item.Manager.ManagerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            var builder = new ApiSdk.Users.Item.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMessagesCommand() {
            var command = new Command("messages");
            var builder = new ApiSdk.Users.Item.Messages.MessagesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new ApiSdk.Users.Item.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            var builder = new ApiSdk.Users.Item.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ApiSdk.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ApiSdk.Users.Item.Outlook.OutlookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMasterCategoriesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildOwnedDevicesCommand() {
            var command = new Command("owned-devices");
            var builder = new ApiSdk.Users.Item.OwnedDevices.OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            var builder = new ApiSdk.Users.Item.OwnedObjects.OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Update entity in users
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string userId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.User>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, userIdOption, bodyOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildPeopleCommand() {
            var command = new Command("people");
            var builder = new ApiSdk.Users.Item.People.PeopleRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            var builder = new ApiSdk.Users.Item.Photo.PhotoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildPhotosCommand() {
            var command = new Command("photos");
            var builder = new ApiSdk.Users.Item.Photos.PhotosRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            var builder = new ApiSdk.Users.Item.Planner.PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            command.AddCommand(builder.BuildTasksCommand());
            return command;
        }
        public Command BuildPresenceCommand() {
            var command = new Command("presence");
            var builder = new ApiSdk.Users.Item.Presence.PresenceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearPresenceCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSetPresenceCommand());
            return command;
        }
        public Command BuildRegisteredDevicesCommand() {
            var command = new Command("registered-devices");
            var builder = new ApiSdk.Users.Item.RegisteredDevices.RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildRemoveAllDevicesFromManagementCommand() {
            var command = new Command("remove-all-devices-from-management");
            var builder = new ApiSdk.Users.Item.RemoveAllDevicesFromManagement.RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReprocessLicenseAssignmentCommand() {
            var command = new Command("reprocess-license-assignment");
            var builder = new ApiSdk.Users.Item.ReprocessLicenseAssignment.ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new ApiSdk.Users.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRevokeSignInSessionsCommand() {
            var command = new Command("revoke-sign-in-sessions");
            var builder = new ApiSdk.Users.Item.RevokeSignInSessions.RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildScopedRoleMemberOfCommand() {
            var command = new Command("scoped-role-member-of");
            var builder = new ApiSdk.Users.Item.ScopedRoleMemberOf.ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSendMailCommand() {
            var command = new Command("send-mail");
            var builder = new ApiSdk.Users.Item.SendMail.SendMailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSettingsCommand() {
            var command = new Command("settings");
            var builder = new ApiSdk.Users.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildShiftPreferencesCommand());
            return command;
        }
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            var builder = new ApiSdk.Users.Item.Teamwork.TeamworkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInstalledAppsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSendActivityNotificationCommand());
            return command;
        }
        public Command BuildTodoCommand() {
            var command = new Command("todo");
            var builder = new ApiSdk.Users.Item.Todo.TodoRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildListsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            var builder = new ApiSdk.Users.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTranslateExchangeIdsCommand() {
            var command = new Command("translate-exchange-ids");
            var builder = new ApiSdk.Users.Item.TranslateExchangeIds.TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWipeManagedAppRegistrationsByDeviceTagCommand() {
            var command = new Command("wipe-managed-app-registrations-by-device-tag");
            var builder = new ApiSdk.Users.Item.WipeManagedAppRegistrationsByDeviceTag.WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from users
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
        /// Get entity from users by key
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
        /// Update entity in users
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
        /// Delete entity from users
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
        /// Get entity from users by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.User> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.User>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update entity in users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.User model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string startDateTime, string endDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime);
        }
        /// <summary>Get entity from users by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
