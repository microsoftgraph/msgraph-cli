using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.DeviceAppManagement.ManagedEBooks.Item.UserStateSummary.Item.DeviceStates.Item {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\managedEBooks\{managedEBook-id}\userStateSummary\{userInstallStateSummary-id}\deviceStates\{deviceInstallState-id}</summary>
    public class DeviceInstallStateItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The install state of the eBook.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The install state of the eBook.";
            // Create options for all the parameters
            var managedEBookIdOption = new Option<string>("--managed-ebook-id", description: "key: id of managedEBook") {
            };
            managedEBookIdOption.IsRequired = true;
            command.AddOption(managedEBookIdOption);
            var userInstallStateSummaryIdOption = new Option<string>("--user-install-state-summary-id", description: "key: id of userInstallStateSummary") {
            };
            userInstallStateSummaryIdOption.IsRequired = true;
            command.AddOption(userInstallStateSummaryIdOption);
            var deviceInstallStateIdOption = new Option<string>("--device-install-state-id", description: "key: id of deviceInstallState") {
            };
            deviceInstallStateIdOption.IsRequired = true;
            command.AddOption(deviceInstallStateIdOption);
            command.SetHandler(async (object[] parameters) => {
                var managedEBookId = (string) parameters[0];
                var userInstallStateSummaryId = (string) parameters[1];
                var deviceInstallStateId = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("managedEBook_id", managedEBookId);
                PathParameters.Add("userInstallStateSummary_id", userInstallStateSummaryId);
                PathParameters.Add("deviceInstallState_id", deviceInstallStateId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(managedEBookIdOption, userInstallStateSummaryIdOption, deviceInstallStateIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The install state of the eBook.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The install state of the eBook.";
            // Create options for all the parameters
            var managedEBookIdOption = new Option<string>("--managed-ebook-id", description: "key: id of managedEBook") {
            };
            managedEBookIdOption.IsRequired = true;
            command.AddOption(managedEBookIdOption);
            var userInstallStateSummaryIdOption = new Option<string>("--user-install-state-summary-id", description: "key: id of userInstallStateSummary") {
            };
            userInstallStateSummaryIdOption.IsRequired = true;
            command.AddOption(userInstallStateSummaryIdOption);
            var deviceInstallStateIdOption = new Option<string>("--device-install-state-id", description: "key: id of deviceInstallState") {
            };
            deviceInstallStateIdOption.IsRequired = true;
            command.AddOption(deviceInstallStateIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var managedEBookId = (string) parameters[0];
                var userInstallStateSummaryId = (string) parameters[1];
                var deviceInstallStateId = (string) parameters[2];
                var select = (string[]) parameters[3];
                var expand = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("managedEBook_id", managedEBookId);
                PathParameters.Add("userInstallStateSummary_id", userInstallStateSummaryId);
                PathParameters.Add("deviceInstallState_id", deviceInstallStateId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(managedEBookIdOption, userInstallStateSummaryIdOption, deviceInstallStateIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The install state of the eBook.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The install state of the eBook.";
            // Create options for all the parameters
            var managedEBookIdOption = new Option<string>("--managed-ebook-id", description: "key: id of managedEBook") {
            };
            managedEBookIdOption.IsRequired = true;
            command.AddOption(managedEBookIdOption);
            var userInstallStateSummaryIdOption = new Option<string>("--user-install-state-summary-id", description: "key: id of userInstallStateSummary") {
            };
            userInstallStateSummaryIdOption.IsRequired = true;
            command.AddOption(userInstallStateSummaryIdOption);
            var deviceInstallStateIdOption = new Option<string>("--device-install-state-id", description: "key: id of deviceInstallState") {
            };
            deviceInstallStateIdOption.IsRequired = true;
            command.AddOption(deviceInstallStateIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var managedEBookId = (string) parameters[0];
                var userInstallStateSummaryId = (string) parameters[1];
                var deviceInstallStateId = (string) parameters[2];
                var body = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("managedEBook_id", managedEBookId);
                PathParameters.Add("userInstallStateSummary_id", userInstallStateSummaryId);
                PathParameters.Add("deviceInstallState_id", deviceInstallStateId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceInstallState>(DeviceInstallState.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(managedEBookIdOption, userInstallStateSummaryIdOption, deviceInstallStateIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceInstallStateItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceInstallStateItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/managedEBooks/{managedEBook_id}/userStateSummary/{userInstallStateSummary_id}/deviceStates/{deviceInstallState_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The install state of the eBook.
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
        /// The install state of the eBook.
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
        /// The install state of the eBook.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceInstallState body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>The install state of the eBook.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
