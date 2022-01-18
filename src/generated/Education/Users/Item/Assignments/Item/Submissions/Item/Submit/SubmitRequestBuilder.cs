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
namespace ApiSdk.Education.Users.Item.Assignments.Item.Submissions.Item.Submit {
    /// <summary>Builds and executes requests for operations under \education\users\{educationUser-id}\assignments\{educationAssignment-id}\submissions\{educationSubmission-id}\microsoft.graph.submit</summary>
    public class SubmitRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action submit
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action submit";
            // Create options for all the parameters
            var educationUserIdOption = new Option<string>("--educationuser-id", description: "key: id of educationUser");
            educationUserIdOption.IsRequired = true;
            command.AddOption(educationUserIdOption);
            var educationAssignmentIdOption = new Option<string>("--educationassignment-id", description: "key: id of educationAssignment");
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--educationsubmission-id", description: "key: id of educationSubmission");
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
            command.Handler = CommandHandler.Create<string, string, string>(async (educationUserId, educationAssignmentId, educationSubmissionId) => {
                var requestInfo = CreatePostRequestInformation(q => {
                });
                var result = await RequestAdapter.SendAsync<SubmitResponse>(requestInfo);
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
        /// Instantiates a new SubmitRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SubmitRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/education/users/{educationUser_id}/assignments/{educationAssignment_id}/submissions/{educationSubmission_id}/microsoft.graph.submit";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action submit
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
        /// Invoke action submit
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<SubmitResponse> PostAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreatePostRequestInformation(h, o);
            return await RequestAdapter.SendAsync<SubmitResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Union type wrapper for classes educationSubmission</summary>
        public class SubmitResponse : IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type educationSubmission</summary>
            public EducationSubmission EducationSubmission { get; set; }
            /// <summary>
            /// Instantiates a new submitResponse and sets the default values.
            /// </summary>
            public SubmitResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"educationSubmission", (o,n) => { (o as SubmitResponse).EducationSubmission = n.GetObjectValue<EducationSubmission>(); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<EducationSubmission>("educationSubmission", EducationSubmission);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
