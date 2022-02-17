using ApiSdk.Admin.ServiceAnnouncement.HealthOverviews.Item.Issues.Item.IncidentReport;
using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.Admin.ServiceAnnouncement.HealthOverviews.Item.Issues.Item {
    /// <summary>Builds and executes requests for operations under \admin\serviceAnnouncement\healthOverviews\{serviceHealth-id}\issues\{serviceHealthIssue-id}</summary>
    public class ServiceHealthIssueRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// A collection of issues that happened on the service, with detailed information for each issue.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "A collection of issues that happened on the service, with detailed information for each issue.";
            // Create options for all the parameters
            var serviceHealthIdOption = new Option<string>("--service-health-id", description: "key: id of serviceHealth") {
            };
            serviceHealthIdOption.IsRequired = true;
            command.AddOption(serviceHealthIdOption);
            var serviceHealthIssueIdOption = new Option<string>("--service-health-issue-id", description: "key: id of serviceHealthIssue") {
            };
            serviceHealthIssueIdOption.IsRequired = true;
            command.AddOption(serviceHealthIssueIdOption);
            command.SetHandler(async (string serviceHealthId, string serviceHealthIssueId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, serviceHealthIdOption, serviceHealthIssueIdOption);
            return command;
        }
        /// <summary>
        /// A collection of issues that happened on the service, with detailed information for each issue.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "A collection of issues that happened on the service, with detailed information for each issue.";
            // Create options for all the parameters
            var serviceHealthIdOption = new Option<string>("--service-health-id", description: "key: id of serviceHealth") {
            };
            serviceHealthIdOption.IsRequired = true;
            command.AddOption(serviceHealthIdOption);
            var serviceHealthIssueIdOption = new Option<string>("--service-health-issue-id", description: "key: id of serviceHealthIssue") {
            };
            serviceHealthIssueIdOption.IsRequired = true;
            command.AddOption(serviceHealthIssueIdOption);
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
            command.SetHandler(async (string serviceHealthId, string serviceHealthIssueId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, serviceHealthIdOption, serviceHealthIssueIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        /// <summary>
        /// A collection of issues that happened on the service, with detailed information for each issue.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "A collection of issues that happened on the service, with detailed information for each issue.";
            // Create options for all the parameters
            var serviceHealthIdOption = new Option<string>("--service-health-id", description: "key: id of serviceHealth") {
            };
            serviceHealthIdOption.IsRequired = true;
            command.AddOption(serviceHealthIdOption);
            var serviceHealthIssueIdOption = new Option<string>("--service-health-issue-id", description: "key: id of serviceHealthIssue") {
            };
            serviceHealthIssueIdOption.IsRequired = true;
            command.AddOption(serviceHealthIssueIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string serviceHealthId, string serviceHealthIssueId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ServiceHealthIssue>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, serviceHealthIdOption, serviceHealthIssueIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new ServiceHealthIssueRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServiceHealthIssueRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/admin/serviceAnnouncement/healthOverviews/{serviceHealth_id}/issues/{serviceHealthIssue_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// A collection of issues that happened on the service, with detailed information for each issue.
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
        /// A collection of issues that happened on the service, with detailed information for each issue.
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
        /// A collection of issues that happened on the service, with detailed information for each issue.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ServiceHealthIssue body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \admin\serviceAnnouncement\healthOverviews\{serviceHealth-id}\issues\{serviceHealthIssue-id}\microsoft.graph.incidentReport()
        /// </summary>
        public IncidentReportRequestBuilder IncidentReport() {
            return new IncidentReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>A collection of issues that happened on the service, with detailed information for each issue.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
