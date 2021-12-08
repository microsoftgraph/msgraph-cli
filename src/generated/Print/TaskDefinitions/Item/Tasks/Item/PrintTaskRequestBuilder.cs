using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Definition;
using ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Trigger;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Print.TaskDefinitions.Item.Tasks.Item {
    /// <summary>Builds and executes requests for operations under \print\taskDefinitions\{printTaskDefinition-id}\tasks\{printTask-id}</summary>
    public class PrintTaskRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildDefinitionCommand() {
            var command = new Command("definition");
            var builder = new ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Definition.DefinitionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--printtaskdefinition-id", description: "key: id of printTaskDefinition"));
            command.AddOption(new Option<string>("--printtask-id", description: "key: id of printTask"));
            command.Handler = CommandHandler.Create<string, string>(async (printTaskDefinitionId, printTaskId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(printTaskDefinitionId)) requestInfo.PathParameters.Add("printTaskDefinition_id", printTaskDefinitionId);
                if (!String.IsNullOrEmpty(printTaskId)) requestInfo.PathParameters.Add("printTask_id", printTaskId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--printtaskdefinition-id", description: "key: id of printTaskDefinition"));
            command.AddOption(new Option<string>("--printtask-id", description: "key: id of printTask"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, object, object>(async (printTaskDefinitionId, printTaskId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(printTaskDefinitionId)) requestInfo.PathParameters.Add("printTaskDefinition_id", printTaskDefinitionId);
                if (!String.IsNullOrEmpty(printTaskId)) requestInfo.PathParameters.Add("printTask_id", printTaskId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<PrintTask>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--printtaskdefinition-id", description: "key: id of printTaskDefinition"));
            command.AddOption(new Option<string>("--printtask-id", description: "key: id of printTask"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string>(async (printTaskDefinitionId, printTaskId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<PrintTask>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(printTaskDefinitionId)) requestInfo.PathParameters.Add("printTaskDefinition_id", printTaskDefinitionId);
                if (!String.IsNullOrEmpty(printTaskId)) requestInfo.PathParameters.Add("printTask_id", printTaskId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildTriggerCommand() {
            var command = new Command("trigger");
            var builder = new ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new PrintTaskRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PrintTaskRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/print/taskDefinitions/{printTaskDefinition_id}/tasks/{printTask_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(PrintTask body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
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
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PrintTask> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<PrintTask>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(PrintTask model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
