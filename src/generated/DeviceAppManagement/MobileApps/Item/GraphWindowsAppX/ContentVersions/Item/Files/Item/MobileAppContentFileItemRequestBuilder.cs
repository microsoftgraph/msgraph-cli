// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.Commit;
using ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.RenewUpload;
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
namespace ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item
{
    /// <summary>
    /// Provides operations to manage the files property of the microsoft.graph.mobileAppContent entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileAppContentFileItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the commit method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCommitNavCommand()
        {
            var command = new Command("commit");
            command.Description = "Provides operations to call the commit method.";
            var builder = new global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.Commit.CommitRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property files for deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property files for deviceAppManagement";
            var mobileAppIdOption = new Option<string>("--mobile-app-id", description: "The unique identifier of mobileApp") {
            };
            mobileAppIdOption.IsRequired = true;
            command.AddOption(mobileAppIdOption);
            var mobileAppContentIdOption = new Option<string>("--mobile-app-content-id", description: "The unique identifier of mobileAppContent") {
            };
            mobileAppContentIdOption.IsRequired = true;
            command.AddOption(mobileAppContentIdOption);
            var mobileAppContentFileIdOption = new Option<string>("--mobile-app-content-file-id", description: "The unique identifier of mobileAppContentFile") {
            };
            mobileAppContentFileIdOption.IsRequired = true;
            command.AddOption(mobileAppContentFileIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var mobileAppId = invocationContext.ParseResult.GetValueForOption(mobileAppIdOption);
                var mobileAppContentId = invocationContext.ParseResult.GetValueForOption(mobileAppContentIdOption);
                var mobileAppContentFileId = invocationContext.ParseResult.GetValueForOption(mobileAppContentFileIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (mobileAppId is not null) requestInfo.PathParameters.Add("mobileApp%2Did", mobileAppId);
                if (mobileAppContentId is not null) requestInfo.PathParameters.Add("mobileAppContent%2Did", mobileAppContentId);
                if (mobileAppContentFileId is not null) requestInfo.PathParameters.Add("mobileAppContentFile%2Did", mobileAppContentFileId);
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
        /// The list of files for this app content version.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The list of files for this app content version.";
            var mobileAppIdOption = new Option<string>("--mobile-app-id", description: "The unique identifier of mobileApp") {
            };
            mobileAppIdOption.IsRequired = true;
            command.AddOption(mobileAppIdOption);
            var mobileAppContentIdOption = new Option<string>("--mobile-app-content-id", description: "The unique identifier of mobileAppContent") {
            };
            mobileAppContentIdOption.IsRequired = true;
            command.AddOption(mobileAppContentIdOption);
            var mobileAppContentFileIdOption = new Option<string>("--mobile-app-content-file-id", description: "The unique identifier of mobileAppContentFile") {
            };
            mobileAppContentFileIdOption.IsRequired = true;
            command.AddOption(mobileAppContentFileIdOption);
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
                var mobileAppId = invocationContext.ParseResult.GetValueForOption(mobileAppIdOption);
                var mobileAppContentId = invocationContext.ParseResult.GetValueForOption(mobileAppContentIdOption);
                var mobileAppContentFileId = invocationContext.ParseResult.GetValueForOption(mobileAppContentFileIdOption);
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
                if (mobileAppId is not null) requestInfo.PathParameters.Add("mobileApp%2Did", mobileAppId);
                if (mobileAppContentId is not null) requestInfo.PathParameters.Add("mobileAppContent%2Did", mobileAppContentId);
                if (mobileAppContentFileId is not null) requestInfo.PathParameters.Add("mobileAppContentFile%2Did", mobileAppContentFileId);
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
        /// Update the navigation property files in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property files in deviceAppManagement";
            var mobileAppIdOption = new Option<string>("--mobile-app-id", description: "The unique identifier of mobileApp") {
            };
            mobileAppIdOption.IsRequired = true;
            command.AddOption(mobileAppIdOption);
            var mobileAppContentIdOption = new Option<string>("--mobile-app-content-id", description: "The unique identifier of mobileAppContent") {
            };
            mobileAppContentIdOption.IsRequired = true;
            command.AddOption(mobileAppContentIdOption);
            var mobileAppContentFileIdOption = new Option<string>("--mobile-app-content-file-id", description: "The unique identifier of mobileAppContentFile") {
            };
            mobileAppContentFileIdOption.IsRequired = true;
            command.AddOption(mobileAppContentFileIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var mobileAppId = invocationContext.ParseResult.GetValueForOption(mobileAppIdOption);
                var mobileAppContentId = invocationContext.ParseResult.GetValueForOption(mobileAppContentIdOption);
                var mobileAppContentFileId = invocationContext.ParseResult.GetValueForOption(mobileAppContentFileIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.MobileAppContentFile>(global::ApiSdk.Models.MobileAppContentFile.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (mobileAppId is not null) requestInfo.PathParameters.Add("mobileApp%2Did", mobileAppId);
                if (mobileAppContentId is not null) requestInfo.PathParameters.Add("mobileAppContent%2Did", mobileAppContentId);
                if (mobileAppContentFileId is not null) requestInfo.PathParameters.Add("mobileAppContentFile%2Did", mobileAppContentFileId);
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
        /// Provides operations to call the renewUpload method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRenewUploadNavCommand()
        {
            var command = new Command("renew-upload");
            command.Description = "Provides operations to call the renewUpload method.";
            var builder = new global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.RenewUpload.RenewUploadRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.MobileAppContentFileItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MobileAppContentFileItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.windowsAppX/contentVersions/{mobileAppContent%2Did}/files/{mobileAppContentFile%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.MobileAppContentFileItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MobileAppContentFileItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.windowsAppX/contentVersions/{mobileAppContent%2Did}/files/{mobileAppContentFile%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property files for deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The list of files for this app content version.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.MobileAppContentFileItemRequestBuilder.MobileAppContentFileItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX.ContentVersions.Item.Files.Item.MobileAppContentFileItemRequestBuilder.MobileAppContentFileItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property files in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.MobileAppContentFile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.MobileAppContentFile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The list of files for this app content version.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MobileAppContentFileItemRequestBuilderGetQueryParameters 
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
