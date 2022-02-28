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
namespace ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.Ref {
    /// <summary>Builds and executes requests for operations under \deviceManagement\termsAndConditions\{termsAndConditionsItem-id}\acceptanceStatuses\{termsAndConditionsAcceptanceStatus-id}\termsAndConditions\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Navigation link to the terms and conditions that are assigned.";
            // Create options for all the parameters
            var termsAndConditionsItemIdOption = new Option<string>("--terms-and-conditions-item-id", description: "key: id of termsAndConditions") {
            };
            termsAndConditionsItemIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsItemIdOption);
            var termsAndConditionsAcceptanceStatusIdOption = new Option<string>("--terms-and-conditions-acceptance-status-id", description: "key: id of termsAndConditionsAcceptanceStatus") {
            };
            termsAndConditionsAcceptanceStatusIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsAcceptanceStatusIdOption);
            command.SetHandler(async (object[] parameters) => {
                var termsAndConditionsItemId = (string) parameters[0];
                var termsAndConditionsAcceptanceStatusId = (string) parameters[1];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("termsAndConditionsItem_id", termsAndConditionsItemId);
                PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(termsAndConditionsItemIdOption, termsAndConditionsAcceptanceStatusIdOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Navigation link to the terms and conditions that are assigned.";
            // Create options for all the parameters
            var termsAndConditionsItemIdOption = new Option<string>("--terms-and-conditions-item-id", description: "key: id of termsAndConditions") {
            };
            termsAndConditionsItemIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsItemIdOption);
            var termsAndConditionsAcceptanceStatusIdOption = new Option<string>("--terms-and-conditions-acceptance-status-id", description: "key: id of termsAndConditionsAcceptanceStatus") {
            };
            termsAndConditionsAcceptanceStatusIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsAcceptanceStatusIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (object[] parameters) => {
                var termsAndConditionsItemId = (string) parameters[0];
                var termsAndConditionsAcceptanceStatusId = (string) parameters[1];
                var output = (FormatterType) parameters[2];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("termsAndConditionsItem_id", termsAndConditionsItemId);
                PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(termsAndConditionsItemIdOption, termsAndConditionsAcceptanceStatusIdOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Navigation link to the terms and conditions that are assigned.";
            // Create options for all the parameters
            var termsAndConditionsItemIdOption = new Option<string>("--terms-and-conditions-item-id", description: "key: id of termsAndConditions") {
            };
            termsAndConditionsItemIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsItemIdOption);
            var termsAndConditionsAcceptanceStatusIdOption = new Option<string>("--terms-and-conditions-acceptance-status-id", description: "key: id of termsAndConditionsAcceptanceStatus") {
            };
            termsAndConditionsAcceptanceStatusIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsAcceptanceStatusIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var termsAndConditionsItemId = (string) parameters[0];
                var termsAndConditionsAcceptanceStatusId = (string) parameters[1];
                var body = (string) parameters[2];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("termsAndConditionsItem_id", termsAndConditionsItemId);
                PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Ref>();
                var requestInfo = CreatePutRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(termsAndConditionsItemIdOption, termsAndConditionsAcceptanceStatusIdOption, bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
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
            UrlTemplate = "{+baseurl}/deviceManagement/termsAndConditions/{termsAndConditionsItem_id}/acceptanceStatuses/{termsAndConditionsAcceptanceStatus_id}/termsAndConditions/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
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
        /// Navigation link to the terms and conditions that are assigned.
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
        /// Navigation link to the terms and conditions that are assigned.
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
