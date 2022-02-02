using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod;
using ApiSdk.Me.Insights.Shared.Item.Resource;
using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.Me.Insights.Shared.Item {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}</summary>
    public class SharedInsightRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Access this property from the derived type itemInsights.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Access this property from the derived type itemInsights.";
            // Create options for all the parameters
            var sharedInsightIdOption = new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight") {
            };
            sharedInsightIdOption.IsRequired = true;
            command.AddOption(sharedInsightIdOption);
            command.SetHandler(async (string sharedInsightId, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, sharedInsightIdOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Access this property from the derived type itemInsights.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Access this property from the derived type itemInsights.";
            // Create options for all the parameters
            var sharedInsightIdOption = new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight") {
            };
            sharedInsightIdOption.IsRequired = true;
            command.AddOption(sharedInsightIdOption);
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
            command.SetHandler(async (string sharedInsightId, string[] select, string[] expand, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                var responseProcessor = serviceProvider.GetService(typeof(IResponseProcessor)) as IResponseProcessor;
                var factory = serviceProvider.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory;
                var formatter = factory.GetFormatter(output);
                if (responseProcessor.IsResponseSuccessful(responseHandler)) {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    formatter.WriteOutput(content, console);
                }
                else {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    console.WriteLine(content);
                }
            }, sharedInsightIdOption, selectOption, expandOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        public Command BuildLastSharedMethodCommand() {
            var command = new Command("last-shared-method");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.LastSharedMethodRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCalendarSharingMessageCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildManagedAppProtectionCommand());
            command.AddCommand(builder.BuildMobileAppContentFileCommand());
            command.AddCommand(builder.BuildPrintDocumentCommand());
            command.AddCommand(builder.BuildPrintJobCommand());
            command.AddCommand(builder.BuildRefCommand());
            command.AddCommand(builder.BuildScheduleChangeRequestCommand());
            command.AddCommand(builder.BuildTargetedManagedAppProtectionCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionCommand());
            command.AddCommand(builder.BuildWorkbookRangeCommand());
            command.AddCommand(builder.BuildWorkbookRangeFillCommand());
            command.AddCommand(builder.BuildWorkbookRangeFormatCommand());
            command.AddCommand(builder.BuildWorkbookRangeSortCommand());
            command.AddCommand(builder.BuildWorkbookRangeViewCommand());
            return command;
        }
        /// <summary>
        /// Access this property from the derived type itemInsights.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Access this property from the derived type itemInsights.";
            // Create options for all the parameters
            var sharedInsightIdOption = new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight") {
            };
            sharedInsightIdOption.IsRequired = true;
            command.AddOption(sharedInsightIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string sharedInsightId, string body, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<SharedInsight>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, sharedInsightIdOption, bodyOption, new ServiceProviderBinder());
            return command;
        }
        public Command BuildResourceCommand() {
            var command = new Command("resource");
            var builder = new ApiSdk.Me.Insights.Shared.Item.Resource.ResourceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCalendarSharingMessageCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildManagedAppProtectionCommand());
            command.AddCommand(builder.BuildMobileAppContentFileCommand());
            command.AddCommand(builder.BuildPrintDocumentCommand());
            command.AddCommand(builder.BuildPrintJobCommand());
            command.AddCommand(builder.BuildRefCommand());
            command.AddCommand(builder.BuildScheduleChangeRequestCommand());
            command.AddCommand(builder.BuildTargetedManagedAppProtectionCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionCommand());
            command.AddCommand(builder.BuildWorkbookRangeCommand());
            command.AddCommand(builder.BuildWorkbookRangeFillCommand());
            command.AddCommand(builder.BuildWorkbookRangeFormatCommand());
            command.AddCommand(builder.BuildWorkbookRangeSortCommand());
            command.AddCommand(builder.BuildWorkbookRangeViewCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new SharedInsightRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SharedInsightRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new SharedInsightRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SharedInsightRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Access this property from the derived type itemInsights.
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
        /// Access this property from the derived type itemInsights.
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
        /// Access this property from the derived type itemInsights.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(SharedInsight body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Access this property from the derived type itemInsights.
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
        /// Access this property from the derived type itemInsights.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<SharedInsight> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<SharedInsight>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Access this property from the derived type itemInsights.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(SharedInsight model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
