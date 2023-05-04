using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies.Item.ProtectedAppLockerFiles.Item {
    /// <summary>
    /// Provides operations to manage the protectedAppLockerFiles property of the microsoft.graph.windowsInformationProtection entity.
    /// </summary>
    public class WindowsInformationProtectionAppLockerFileItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Delete navigation property protectedAppLockerFiles for deviceAppManagement
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property protectedAppLockerFiles for deviceAppManagement";
            var windowsInformationProtectionPolicyIdOption = new Option<string>("--windows-information-protection-policy-id", description: "The unique identifier of windowsInformationProtectionPolicy") {
            };
            windowsInformationProtectionPolicyIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionPolicyIdOption);
            var windowsInformationProtectionAppLockerFileIdOption = new Option<string>("--windows-information-protection-app-locker-file-id", description: "The unique identifier of windowsInformationProtectionAppLockerFile") {
            };
            windowsInformationProtectionAppLockerFileIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionAppLockerFileIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var windowsInformationProtectionPolicyId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionPolicyIdOption);
                var windowsInformationProtectionAppLockerFileId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionAppLockerFileIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (windowsInformationProtectionPolicyId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionPolicy%2Did", windowsInformationProtectionPolicyId);
                if (windowsInformationProtectionAppLockerFileId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionAppLockerFile%2Did", windowsInformationProtectionAppLockerFileId);
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
        /// Another way to input protected apps through xml files
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Another way to input protected apps through xml files";
            var windowsInformationProtectionPolicyIdOption = new Option<string>("--windows-information-protection-policy-id", description: "The unique identifier of windowsInformationProtectionPolicy") {
            };
            windowsInformationProtectionPolicyIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionPolicyIdOption);
            var windowsInformationProtectionAppLockerFileIdOption = new Option<string>("--windows-information-protection-app-locker-file-id", description: "The unique identifier of windowsInformationProtectionAppLockerFile") {
            };
            windowsInformationProtectionAppLockerFileIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionAppLockerFileIdOption);
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
                var windowsInformationProtectionPolicyId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionPolicyIdOption);
                var windowsInformationProtectionAppLockerFileId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionAppLockerFileIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (windowsInformationProtectionPolicyId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionPolicy%2Did", windowsInformationProtectionPolicyId);
                if (windowsInformationProtectionAppLockerFileId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionAppLockerFile%2Did", windowsInformationProtectionAppLockerFileId);
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
        /// Update the navigation property protectedAppLockerFiles in deviceAppManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property protectedAppLockerFiles in deviceAppManagement";
            var windowsInformationProtectionPolicyIdOption = new Option<string>("--windows-information-protection-policy-id", description: "The unique identifier of windowsInformationProtectionPolicy") {
            };
            windowsInformationProtectionPolicyIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionPolicyIdOption);
            var windowsInformationProtectionAppLockerFileIdOption = new Option<string>("--windows-information-protection-app-locker-file-id", description: "The unique identifier of windowsInformationProtectionAppLockerFile") {
            };
            windowsInformationProtectionAppLockerFileIdOption.IsRequired = true;
            command.AddOption(windowsInformationProtectionAppLockerFileIdOption);
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
                var windowsInformationProtectionPolicyId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionPolicyIdOption);
                var windowsInformationProtectionAppLockerFileId = invocationContext.ParseResult.GetValueForOption(windowsInformationProtectionAppLockerFileIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WindowsInformationProtectionAppLockerFile>(WindowsInformationProtectionAppLockerFile.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (windowsInformationProtectionPolicyId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionPolicy%2Did", windowsInformationProtectionPolicyId);
                if (windowsInformationProtectionAppLockerFileId is not null) requestInfo.PathParameters.Add("windowsInformationProtectionAppLockerFile%2Did", windowsInformationProtectionAppLockerFileId);
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
        /// Instantiates a new WindowsInformationProtectionAppLockerFileItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WindowsInformationProtectionAppLockerFileItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicy%2Did}/protectedAppLockerFiles/{windowsInformationProtectionAppLockerFile%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete navigation property protectedAppLockerFiles for deviceAppManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Another way to input protected apps through xml files
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WindowsInformationProtectionAppLockerFileItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WindowsInformationProtectionAppLockerFileItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<WindowsInformationProtectionAppLockerFileItemRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property protectedAppLockerFiles in deviceAppManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WindowsInformationProtectionAppLockerFile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WindowsInformationProtectionAppLockerFile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Another way to input protected apps through xml files
        /// </summary>
        public class WindowsInformationProtectionAppLockerFileItemRequestBuilderGetQueryParameters {
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
