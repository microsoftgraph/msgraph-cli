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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.Assignments.Item.AccessPackage.GetApplicablePolicyRequirements {
    /// <summary>Builds and executes requests for operations under \identityGovernance\entitlementManagement\assignments\{accessPackageAssignment-id}\accessPackage\microsoft.graph.getApplicablePolicyRequirements</summary>
    public class GetApplicablePolicyRequirementsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action getApplicablePolicyRequirements
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action getApplicablePolicyRequirements";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--accesspackageassignment-id", description: "key: id of accessPackageAssignment"));
            command.Handler = CommandHandler.Create<string>(async (accessPackageAssignmentId) => {
                var requestInfo = CreatePostRequestInformation();
                if (!String.IsNullOrEmpty(accessPackageAssignmentId)) requestInfo.PathParameters.Add("accessPackageAssignment_id", accessPackageAssignmentId);
                var result = await RequestAdapter.SendCollectionAsync<ApiSdk.IdentityGovernance.EntitlementManagement.Assignments.Item.AccessPackage.GetApplicablePolicyRequirements.GetApplicablePolicyRequirements>(requestInfo);
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
        /// Instantiates a new GetApplicablePolicyRequirementsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetApplicablePolicyRequirementsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/assignments/{accessPackageAssignment_id}/accessPackage/microsoft.graph.getApplicablePolicyRequirements";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action getApplicablePolicyRequirements
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke action getApplicablePolicyRequirements
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.IdentityGovernance.EntitlementManagement.Assignments.Item.AccessPackage.GetApplicablePolicyRequirements.GetApplicablePolicyRequirements>> PostAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreatePostRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.IdentityGovernance.EntitlementManagement.Assignments.Item.AccessPackage.GetApplicablePolicyRequirements.GetApplicablePolicyRequirements>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
