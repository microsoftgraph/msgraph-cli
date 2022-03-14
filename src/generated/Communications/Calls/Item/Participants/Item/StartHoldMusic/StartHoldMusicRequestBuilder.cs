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
namespace ApiSdk.Communications.Calls.Item.Participants.Item.StartHoldMusic {
    /// <summary>Builds and executes requests for operations under \communications\calls\{call-id}\participants\{participant-id}\microsoft.graph.startHoldMusic</summary>
    public class StartHoldMusicRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action startHoldMusic
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action startHoldMusic";
            // Create options for all the parameters
            var callIdOption = new Option<string>("--call-id", description: "key: id of call") {
            };
            callIdOption.IsRequired = true;
            command.AddOption(callIdOption);
            var participantIdOption = new Option<string>("--participant-id", description: "key: id of participant") {
            };
            participantIdOption.IsRequired = true;
            command.AddOption(participantIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
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
                var callId = (string) parameters[0];
                var participantId = (string) parameters[1];
                var body = (string) parameters[2];
                var output = (FormatterType) parameters[3];
                var query = (string) parameters[4];
                var jsonNoIndent = (bool) parameters[5];
                var outputFilter = (IOutputFilter) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("call_id", callId);
                PathParameters.Add("participant_id", participantId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<StartHoldMusicRequestBody>(StartHoldMusicRequestBody.CreateFromDiscriminatorValue);
                var requestInfo = CreatePostRequestInformation(model, q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(callIdOption, participantIdOption, bodyOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new StartHoldMusicRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public StartHoldMusicRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/calls/{call_id}/participants/{participant_id}/microsoft.graph.startHoldMusic";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action startHoldMusic
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(StartHoldMusicRequestBody body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>Union type wrapper for classes startHoldMusicOperation</summary>
        public class StartHoldMusicResponse : IAdditionalDataHolder, IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type startHoldMusicOperation</summary>
            public ApiSdk.Models.Microsoft.Graph.StartHoldMusicOperation StartHoldMusicOperation { get; set; }
            /// <summary>
            /// Instantiates a new startHoldMusicResponse and sets the default values.
            /// </summary>
            public StartHoldMusicResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            public static StartHoldMusicResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                return new StartHoldMusicResponse();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"startHoldMusicOperation", (o,n) => { (o as StartHoldMusicResponse).StartHoldMusicOperation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.StartHoldMusicOperation>(ApiSdk.Models.Microsoft.Graph.StartHoldMusicOperation.CreateFromDiscriminatorValue); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.StartHoldMusicOperation>("startHoldMusicOperation", StartHoldMusicOperation);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
