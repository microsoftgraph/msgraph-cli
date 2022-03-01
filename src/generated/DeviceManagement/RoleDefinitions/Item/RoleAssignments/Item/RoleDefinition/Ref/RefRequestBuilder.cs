using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement.RoleDefinitions.Item.RoleAssignments.Item.RoleDefinition.Ref {
    /// <summary>Builds and executes requests for operations under \deviceManagement\roleDefinitions\{roleDefinition-id}\roleAssignments\{roleAssignment-id}\roleDefinition\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Role definition this assignment is part of.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Role definition this assignment is part of.";
            // Create options for all the parameters
            var roleDefinitionIdOption = new Option<string>("--role-definition-id", description: "key: id of roleDefinition") {
            };
            roleDefinitionIdOption.IsRequired = true;
            command.AddOption(roleDefinitionIdOption);
            var roleAssignmentIdOption = new Option<string>("--role-assignment-id", description: "key: id of roleAssignment") {
            };
            roleAssignmentIdOption.IsRequired = true;
            command.AddOption(roleAssignmentIdOption);
            command.SetHandler(async (object[] parameters) => {
                var roleDefinitionId = (string) parameters[0];
                var roleAssignmentId = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("roleDefinition_id", roleDefinitionId);
                PathParameters.Add("roleAssignment_id", roleAssignmentId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(roleDefinitionIdOption, roleAssignmentIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Role definition this assignment is part of.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Role definition this assignment is part of.";
            // Create options for all the parameters
            var roleDefinitionIdOption = new Option<string>("--role-definition-id", description: "key: id of roleDefinition") {
            };
            roleDefinitionIdOption.IsRequired = true;
            command.AddOption(roleDefinitionIdOption);
            var roleAssignmentIdOption = new Option<string>("--role-assignment-id", description: "key: id of roleAssignment") {
            };
            roleAssignmentIdOption.IsRequired = true;
            command.AddOption(roleAssignmentIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (object[] parameters) => {
                var roleDefinitionId = (string) parameters[0];
                var roleAssignmentId = (string) parameters[1];
                var output = (FormatterType) parameters[2];
                var query = (string) parameters[3];
                var outputFilter = (IOutputFilter) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("roleDefinition_id", roleDefinitionId);
                PathParameters.Add("roleAssignment_id", roleAssignmentId);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = outputFilter?.FilterOutput(response, query) ?? response;
                formatter.WriteOutput(response);
            }, new CollectionBinding(roleDefinitionIdOption, roleAssignmentIdOption, outputOption, queryOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Role definition this assignment is part of.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Role definition this assignment is part of.";
            // Create options for all the parameters
            var roleDefinitionIdOption = new Option<string>("--role-definition-id", description: "key: id of roleDefinition") {
            };
            roleDefinitionIdOption.IsRequired = true;
            command.AddOption(roleDefinitionIdOption);
            var roleAssignmentIdOption = new Option<string>("--role-assignment-id", description: "key: id of roleAssignment") {
            };
            roleAssignmentIdOption.IsRequired = true;
            command.AddOption(roleAssignmentIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var roleDefinitionId = (string) parameters[0];
                var roleAssignmentId = (string) parameters[1];
                var body = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("roleDefinition_id", roleDefinitionId);
                PathParameters.Add("roleAssignment_id", roleAssignmentId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Ref>();
                var requestInfo = CreatePutRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(roleDefinitionIdOption, roleAssignmentIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
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
            UrlTemplate = "{+baseurl}/deviceManagement/roleDefinitions/{roleDefinition_id}/roleAssignments/{roleAssignment_id}/roleDefinition/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Role definition this assignment is part of.
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
        /// Role definition this assignment is part of.
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
        /// Role definition this assignment is part of.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
