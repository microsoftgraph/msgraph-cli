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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.FilterByCurrentUserWithOn {
    /// <summary>Builds and executes requests for operations under \identityGovernance\entitlementManagement\accessPackageAssignmentApprovals\microsoft.graph.filterByCurrentUser(on={on})</summary>
    public class FilterByCurrentUserWithOnRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function filterByCurrentUser
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function filterByCurrentUser";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--on", description: "Usage: on={on}"));
            command.Handler = CommandHandler.Create<string>(async (on) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(on)) requestInfo.PathParameters.Add("on", on);
                var result = await RequestAdapter.SendCollectionAsync<ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.FilterByCurrentUserWithOn.FilterByCurrentUserWithOn>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteCollectionOfObjectValues(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new FilterByCurrentUserWithOnRequestBuilder and sets the default values.
        /// <param name="on">Usage: on={on}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FilterByCurrentUserWithOnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string on = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignmentApprovals/microsoft.graph.filterByCurrentUser(on={on})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("on", on);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function filterByCurrentUser
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function filterByCurrentUser
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.FilterByCurrentUserWithOn.FilterByCurrentUserWithOn>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.FilterByCurrentUserWithOn.FilterByCurrentUserWithOn>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
