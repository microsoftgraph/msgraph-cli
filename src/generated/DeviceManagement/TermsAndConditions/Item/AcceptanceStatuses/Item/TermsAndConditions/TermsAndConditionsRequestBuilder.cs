using ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.Ref;
using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions {
    /// <summary>Builds and executes requests for operations under \deviceManagement\termsAndConditions\{termsAndConditions-id}\acceptanceStatuses\{termsAndConditionsAcceptanceStatus-id}\termsAndConditions</summary>
    public class TermsAndConditionsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Navigation link to the terms and conditions that are assigned.";
            // Create options for all the parameters
            var termsAndConditionsIdOption = new Option<string>("--termsandconditions-id", description: "key: id of termsAndConditions");
            termsAndConditionsIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsIdOption);
            var termsAndConditionsAcceptanceStatusIdOption = new Option<string>("--termsandconditionsacceptancestatus-id", description: "key: id of termsAndConditionsAcceptanceStatus");
            termsAndConditionsAcceptanceStatusIdOption.IsRequired = true;
            command.AddOption(termsAndConditionsAcceptanceStatusIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned");
            selectOption.IsRequired = false;
            selectOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities");
            expandOption.IsRequired = false;
            expandOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(expandOption);
            command.Handler = CommandHandler.Create<string, string, string[], string[]>(async (termsAndConditionsId, termsAndConditionsAcceptanceStatusId, select, expand) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var result = await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.TermsAndConditions>(requestInfo);
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
        public Command BuildRefCommand() {
            var command = new Command("ref");
            var builder = new ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.@Ref.RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new TermsAndConditionsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TermsAndConditionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/termsAndConditions/{termsAndConditions_id}/acceptanceStatuses/{termsAndConditionsAcceptanceStatus_id}/termsAndConditions{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
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
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.TermsAndConditions> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.TermsAndConditions>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
