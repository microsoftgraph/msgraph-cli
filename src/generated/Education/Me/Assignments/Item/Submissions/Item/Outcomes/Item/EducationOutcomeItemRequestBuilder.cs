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
namespace ApiSdk.Education.Me.Assignments.Item.Submissions.Item.Outcomes.Item {
    /// <summary>Provides operations to manage the outcomes property of the microsoft.graph.educationSubmission entity.</summary>
    public class EducationOutcomeItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property outcomes for education
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property outcomes for education";
            // Create options for all the parameters
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "key: id of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "key: id of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
            var educationOutcomeIdOption = new Option<string>("--education-outcome-id", description: "key: id of educationOutcome") {
            };
            educationOutcomeIdOption.IsRequired = true;
            command.AddOption(educationOutcomeIdOption);
            var ifMatchOption = new Option<string>("--if-match", description: "ETag") {
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
                var educationOutcomeId = invocationContext.ParseResult.GetValueForOption(educationOutcomeIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
                requestInfo.PathParameters.Add("educationOutcome%2Did", educationOutcomeId);
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
        /// Get outcomes from education
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get outcomes from education";
            // Create options for all the parameters
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "key: id of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "key: id of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
            var educationOutcomeIdOption = new Option<string>("--education-outcome-id", description: "key: id of educationOutcome") {
            };
            educationOutcomeIdOption.IsRequired = true;
            command.AddOption(educationOutcomeIdOption);
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
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
                var educationOutcomeId = invocationContext.ParseResult.GetValueForOption(educationOutcomeIdOption);
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
                requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
                requestInfo.PathParameters.Add("educationOutcome%2Did", educationOutcomeId);
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
        /// Update the navigation property outcomes in education
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property outcomes in education";
            // Create options for all the parameters
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "key: id of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "key: id of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
            var educationOutcomeIdOption = new Option<string>("--education-outcome-id", description: "key: id of educationOutcome") {
            };
            educationOutcomeIdOption.IsRequired = true;
            command.AddOption(educationOutcomeIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
                var educationOutcomeId = invocationContext.ParseResult.GetValueForOption(educationOutcomeIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<EducationOutcome>(EducationOutcome.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
                requestInfo.PathParameters.Add("educationOutcome%2Did", educationOutcomeId);
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
        /// Instantiates a new EducationOutcomeItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EducationOutcomeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/education/me/assignments/{educationAssignment%2Did}/submissions/{educationSubmission%2Did}/outcomes/{educationOutcome%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property outcomes for education
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<EducationOutcomeItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EducationOutcomeItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get outcomes from education
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<EducationOutcomeItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EducationOutcomeItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property outcomes in education
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(EducationOutcome body, Action<EducationOutcomeItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EducationOutcomeItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EducationOutcomeItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new educationOutcomeItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EducationOutcomeItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Get outcomes from education</summary>
        public class EducationOutcomeItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EducationOutcomeItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EducationOutcomeItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EducationOutcomeItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new educationOutcomeItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EducationOutcomeItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EducationOutcomeItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new educationOutcomeItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EducationOutcomeItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
