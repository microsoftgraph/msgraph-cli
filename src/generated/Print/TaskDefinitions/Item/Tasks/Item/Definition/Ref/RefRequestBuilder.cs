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
namespace ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Definition.Ref {
    /// <summary>Builds and executes requests for operations under \print\taskDefinitions\{printTaskDefinition-id}\tasks\{printTask-id}\definition\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The printTaskDefinition that was used to create this task. Read-only.";
            // Create options for all the parameters
            var printTaskDefinitionIdOption = new Option<string>("--print-task-definition-id", description: "key: id of printTaskDefinition") {
            };
            printTaskDefinitionIdOption.IsRequired = true;
            command.AddOption(printTaskDefinitionIdOption);
            var printTaskIdOption = new Option<string>("--print-task-id", description: "key: id of printTask") {
            };
            printTaskIdOption.IsRequired = true;
            command.AddOption(printTaskIdOption);
            command.SetHandler(async (string printTaskDefinitionId, string printTaskId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, printTaskDefinitionIdOption, printTaskIdOption);
            return command;
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The printTaskDefinition that was used to create this task. Read-only.";
            // Create options for all the parameters
            var printTaskDefinitionIdOption = new Option<string>("--print-task-definition-id", description: "key: id of printTaskDefinition") {
            };
            printTaskDefinitionIdOption.IsRequired = true;
            command.AddOption(printTaskDefinitionIdOption);
            var printTaskIdOption = new Option<string>("--print-task-id", description: "key: id of printTask") {
            };
            printTaskIdOption.IsRequired = true;
            command.AddOption(printTaskIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string printTaskDefinitionId, string printTaskId, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, printTaskDefinitionIdOption, printTaskIdOption, outputOption);
            return command;
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The printTaskDefinition that was used to create this task. Read-only.";
            // Create options for all the parameters
            var printTaskDefinitionIdOption = new Option<string>("--print-task-definition-id", description: "key: id of printTaskDefinition") {
            };
            printTaskDefinitionIdOption.IsRequired = true;
            command.AddOption(printTaskDefinitionIdOption);
            var printTaskIdOption = new Option<string>("--print-task-id", description: "key: id of printTask") {
            };
            printTaskIdOption.IsRequired = true;
            command.AddOption(printTaskIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string printTaskDefinitionId, string printTaskId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Definition.Ref.Ref>();
                var requestInfo = CreatePutRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, printTaskDefinitionIdOption, printTaskIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RefRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/print/taskDefinitions/{printTaskDefinition_id}/tasks/{printTask_id}/definition/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
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
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(ApiSdk.Print.TaskDefinitions.Item.Tasks.Item.Definition.Ref.Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
    }
}
