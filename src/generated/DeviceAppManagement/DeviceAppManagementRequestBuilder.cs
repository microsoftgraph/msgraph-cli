// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.DeviceAppManagement.AndroidManagedAppProtections;
using ApiSdk.DeviceAppManagement.DefaultManagedAppProtections;
using ApiSdk.DeviceAppManagement.IosManagedAppProtections;
using ApiSdk.DeviceAppManagement.ManagedAppPolicies;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations;
using ApiSdk.DeviceAppManagement.ManagedAppStatuses;
using ApiSdk.DeviceAppManagement.ManagedEBooks;
using ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using ApiSdk.DeviceAppManagement.MobileAppCategories;
using ApiSdk.DeviceAppManagement.MobileAppConfigurations;
using ApiSdk.DeviceAppManagement.MobileApps;
using ApiSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations;
using ApiSdk.DeviceAppManagement.VppTokens;
using ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.DeviceAppManagement
{
    /// <summary>
    /// Provides operations to manage the deviceAppManagement singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceAppManagementRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the androidManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAndroidManagedAppProtectionsNavCommand()
        {
            var command = new Command("android-managed-app-protections");
            command.Description = "Provides operations to manage the androidManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.AndroidManagedAppProtections.AndroidManagedAppProtectionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the defaultManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDefaultManagedAppProtectionsNavCommand()
        {
            var command = new Command("default-managed-app-protections");
            command.Description = "Provides operations to manage the defaultManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.DefaultManagedAppProtections.DefaultManagedAppProtectionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Read properties and relationships of the deviceAppManagement object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-partnerintegration-deviceappmanagement-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read properties and relationships of the deviceAppManagement object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-partnerintegration-deviceappmanagement-get?view=graph-rest-1.0";
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the iosManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildIosManagedAppProtectionsNavCommand()
        {
            var command = new Command("ios-managed-app-protections");
            command.Description = "Provides operations to manage the iosManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.IosManagedAppProtections.IosManagedAppProtectionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedAppPolicies property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildManagedAppPoliciesNavCommand()
        {
            var command = new Command("managed-app-policies");
            command.Description = "Provides operations to manage the managedAppPolicies property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.ManagedAppPolicies.ManagedAppPoliciesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedAppRegistrations property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildManagedAppRegistrationsNavCommand()
        {
            var command = new Command("managed-app-registrations");
            command.Description = "Provides operations to manage the managedAppRegistrations property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.ManagedAppRegistrations.ManagedAppRegistrationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGetUserIdsWithFlaggedAppRegistrationNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedAppStatuses property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildManagedAppStatusesNavCommand()
        {
            var command = new Command("managed-app-statuses");
            command.Description = "Provides operations to manage the managedAppStatuses property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.ManagedAppStatuses.ManagedAppStatusesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedEBooks property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildManagedEBooksNavCommand()
        {
            var command = new Command("managed-e-books");
            command.Description = "Provides operations to manage the managedEBooks property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.ManagedEBooks.ManagedEBooksRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mdmWindowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMdmWindowsInformationProtectionPoliciesNavCommand()
        {
            var command = new Command("mdm-windows-information-protection-policies");
            command.Description = "Provides operations to manage the mdmWindowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mobileAppCategories property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMobileAppCategoriesNavCommand()
        {
            var command = new Command("mobile-app-categories");
            command.Description = "Provides operations to manage the mobileAppCategories property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.MobileAppCategories.MobileAppCategoriesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mobileAppConfigurations property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMobileAppConfigurationsNavCommand()
        {
            var command = new Command("mobile-app-configurations");
            command.Description = "Provides operations to manage the mobileAppConfigurations property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.MobileAppConfigurations.MobileAppConfigurationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMobileAppsNavCommand()
        {
            var command = new Command("mobile-apps");
            command.Description = "Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGraphAndroidLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphAndroidStoreAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphIosLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphIosStoreAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphIosVppAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphMacOSDmgAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphMacOSLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphManagedAndroidLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphManagedIOSLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphManagedMobileLobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphMicrosoftStoreForBusinessAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphWin32LobAppNavCommand());
            nonExecCommands.Add(builder.BuildGraphWindowsAppXNavCommand());
            nonExecCommands.Add(builder.BuildGraphWindowsMobileMSINavCommand());
            nonExecCommands.Add(builder.BuildGraphWindowsUniversalAppXNavCommand());
            nonExecCommands.Add(builder.BuildGraphWindowsWebAppNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the properties of a deviceAppManagement object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-unlock-deviceappmanagement-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of a deviceAppManagement object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-unlock-deviceappmanagement-update?view=graph-rest-1.0";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.DeviceAppManagement>(global::ApiSdk.Models.DeviceAppManagement.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the syncMicrosoftStoreForBusinessApps method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSyncMicrosoftStoreForBusinessAppsNavCommand()
        {
            var command = new Command("sync-microsoft-store-for-business-apps");
            command.Description = "Provides operations to call the syncMicrosoftStoreForBusinessApps method.";
            var builder = new global::ApiSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps.SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the targetedManagedAppConfigurations property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTargetedManagedAppConfigurationsNavCommand()
        {
            var command = new Command("targeted-managed-app-configurations");
            command.Description = "Provides operations to manage the targetedManagedAppConfigurations property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations.TargetedManagedAppConfigurationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the vppTokens property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildVppTokensNavCommand()
        {
            var command = new Command("vpp-tokens");
            command.Description = "Provides operations to manage the vppTokens property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.VppTokens.VppTokensRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the windowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWindowsInformationProtectionPoliciesNavCommand()
        {
            var command = new Command("windows-information-protection-policies");
            command.Description = "Provides operations to manage the windowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.";
            var builder = new global::ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies.WindowsInformationProtectionPoliciesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceAppManagementRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceAppManagementRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Read properties and relationships of the deviceAppManagement object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder.DeviceAppManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder.DeviceAppManagementRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a deviceAppManagement object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DeviceAppManagement body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DeviceAppManagement body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the deviceAppManagement object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DeviceAppManagementRequestBuilderGetQueryParameters 
        {
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
    }
}
#pragma warning restore CS0618
