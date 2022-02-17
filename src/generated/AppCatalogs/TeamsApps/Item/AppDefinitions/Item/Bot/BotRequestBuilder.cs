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
namespace ApiSdk.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.Bot {
    /// <summary>Builds and executes requests for operations under \appCatalogs\teamsApps\{teamsApp-id}\appDefinitions\{teamsAppDefinition-id}\bot</summary>
    public class BotRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The details of the bot specified in the Teams app manifest.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The details of the bot specified in the Teams app manifest.";
            // Create options for all the parameters
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "key: id of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "key: id of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
            command.SetHandler(async (string teamsAppId, string teamsAppDefinitionId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, teamsAppIdOption, teamsAppDefinitionIdOption);
            return command;
        }
        /// <summary>
        /// The details of the bot specified in the Teams app manifest.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The details of the bot specified in the Teams app manifest.";
            // Create options for all the parameters
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "key: id of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "key: id of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
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
            command.SetHandler(async (string teamsAppId, string teamsAppDefinitionId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, teamsAppIdOption, teamsAppDefinitionIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        /// <summary>
        /// The details of the bot specified in the Teams app manifest.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The details of the bot specified in the Teams app manifest.";
            // Create options for all the parameters
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "key: id of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "key: id of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string teamsAppId, string teamsAppDefinitionId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<TeamworkBot>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, teamsAppIdOption, teamsAppDefinitionIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new BotRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public BotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/appCatalogs/teamsApps/{teamsApp_id}/appDefinitions/{teamsAppDefinition_id}/bot{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The details of the bot specified in the Teams app manifest.
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
        /// The details of the bot specified in the Teams app manifest.
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
        /// The details of the bot specified in the Teams app manifest.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(TeamworkBot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>The details of the bot specified in the Teams app manifest.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
