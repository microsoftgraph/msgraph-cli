using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Agreements.Item.Files.Item.Versions.Item {
    /// <summary>Provides operations to manage the versions property of the microsoft.graph.agreementFileLocalization entity.</summary>
    public class AgreementFileVersionItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property versions for agreements
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property versions for agreements";
            // Create options for all the parameters
            var agreementIdOption = new Option<string>("--agreement-id", description: "key: id of agreement") {
            };
            agreementIdOption.IsRequired = true;
            command.AddOption(agreementIdOption);
            var agreementFileLocalizationIdOption = new Option<string>("--agreement-file-localization-id", description: "key: id of agreementFileLocalization") {
            };
            agreementFileLocalizationIdOption.IsRequired = true;
            command.AddOption(agreementFileLocalizationIdOption);
            var agreementFileVersionIdOption = new Option<string>("--agreement-file-version-id", description: "key: id of agreementFileVersion") {
            };
            agreementFileVersionIdOption.IsRequired = true;
            command.AddOption(agreementFileVersionIdOption);
            var ifMatchOption = new Option<string>("--if-match", description: "ETag") {
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var agreementId = invocationContext.ParseResult.GetValueForOption(agreementIdOption);
                var agreementFileLocalizationId = invocationContext.ParseResult.GetValueForOption(agreementFileLocalizationIdOption);
                var agreementFileVersionId = invocationContext.ParseResult.GetValueForOption(agreementFileVersionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("agreement%2Did", agreementId);
                requestInfo.PathParameters.Add("agreementFileLocalization%2Did", agreementFileLocalizationId);
                requestInfo.PathParameters.Add("agreementFileVersion%2Did", agreementFileVersionId);
                requestInfo.Headers["If-Match"] = ifMatch;
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
        /// Read-only. Customized versions of the terms of use agreement in the Azure AD tenant.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read-only. Customized versions of the terms of use agreement in the Azure AD tenant.";
            // Create options for all the parameters
            var agreementIdOption = new Option<string>("--agreement-id", description: "key: id of agreement") {
            };
            agreementIdOption.IsRequired = true;
            command.AddOption(agreementIdOption);
            var agreementFileLocalizationIdOption = new Option<string>("--agreement-file-localization-id", description: "key: id of agreementFileLocalization") {
            };
            agreementFileLocalizationIdOption.IsRequired = true;
            command.AddOption(agreementFileLocalizationIdOption);
            var agreementFileVersionIdOption = new Option<string>("--agreement-file-version-id", description: "key: id of agreementFileVersion") {
            };
            agreementFileVersionIdOption.IsRequired = true;
            command.AddOption(agreementFileVersionIdOption);
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
                var agreementId = invocationContext.ParseResult.GetValueForOption(agreementIdOption);
                var agreementFileLocalizationId = invocationContext.ParseResult.GetValueForOption(agreementFileLocalizationIdOption);
                var agreementFileVersionId = invocationContext.ParseResult.GetValueForOption(agreementFileVersionIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                requestInfo.PathParameters.Add("agreement%2Did", agreementId);
                requestInfo.PathParameters.Add("agreementFileLocalization%2Did", agreementFileLocalizationId);
                requestInfo.PathParameters.Add("agreementFileVersion%2Did", agreementFileVersionId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the navigation property versions in agreements
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property versions in agreements";
            // Create options for all the parameters
            var agreementIdOption = new Option<string>("--agreement-id", description: "key: id of agreement") {
            };
            agreementIdOption.IsRequired = true;
            command.AddOption(agreementIdOption);
            var agreementFileLocalizationIdOption = new Option<string>("--agreement-file-localization-id", description: "key: id of agreementFileLocalization") {
            };
            agreementFileLocalizationIdOption.IsRequired = true;
            command.AddOption(agreementFileLocalizationIdOption);
            var agreementFileVersionIdOption = new Option<string>("--agreement-file-version-id", description: "key: id of agreementFileVersion") {
            };
            agreementFileVersionIdOption.IsRequired = true;
            command.AddOption(agreementFileVersionIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var agreementId = invocationContext.ParseResult.GetValueForOption(agreementIdOption);
                var agreementFileLocalizationId = invocationContext.ParseResult.GetValueForOption(agreementFileLocalizationIdOption);
                var agreementFileVersionId = invocationContext.ParseResult.GetValueForOption(agreementFileVersionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AgreementFileVersion>(AgreementFileVersion.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                requestInfo.PathParameters.Add("agreement%2Did", agreementId);
                requestInfo.PathParameters.Add("agreementFileLocalization%2Did", agreementFileLocalizationId);
                requestInfo.PathParameters.Add("agreementFileVersion%2Did", agreementFileVersionId);
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
        /// Instantiates a new AgreementFileVersionItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AgreementFileVersionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/agreements/{agreement%2Did}/files/{agreementFileLocalization%2Did}/versions/{agreementFileVersion%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property versions for agreements
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<AgreementFileVersionItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AgreementFileVersionItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read-only. Customized versions of the terms of use agreement in the Azure AD tenant.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<AgreementFileVersionItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AgreementFileVersionItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property versions in agreements
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AgreementFileVersion body, Action<AgreementFileVersionItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new AgreementFileVersionItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AgreementFileVersionItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new agreementFileVersionItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AgreementFileVersionItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Read-only. Customized versions of the terms of use agreement in the Azure AD tenant.</summary>
        public class AgreementFileVersionItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AgreementFileVersionItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AgreementFileVersionItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AgreementFileVersionItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new agreementFileVersionItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AgreementFileVersionItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AgreementFileVersionItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new agreementFileVersionItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AgreementFileVersionItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
