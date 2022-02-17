using ApiSdk.Communications.Calls.Item.Answer;
using ApiSdk.Communications.Calls.Item.AudioRoutingGroups;
using ApiSdk.Communications.Calls.Item.CancelMediaProcessing;
using ApiSdk.Communications.Calls.Item.ChangeScreenSharingRole;
using ApiSdk.Communications.Calls.Item.KeepAlive;
using ApiSdk.Communications.Calls.Item.Mute;
using ApiSdk.Communications.Calls.Item.Operations;
using ApiSdk.Communications.Calls.Item.Participants;
using ApiSdk.Communications.Calls.Item.PlayPrompt;
using ApiSdk.Communications.Calls.Item.RecordResponse;
using ApiSdk.Communications.Calls.Item.Redirect;
using ApiSdk.Communications.Calls.Item.Reject;
using ApiSdk.Communications.Calls.Item.SubscribeToTone;
using ApiSdk.Communications.Calls.Item.Transfer;
using ApiSdk.Communications.Calls.Item.Unmute;
using ApiSdk.Communications.Calls.Item.UpdateRecordingStatus;
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
namespace ApiSdk.Communications.Calls.Item {
    /// <summary>Builds and executes requests for operations under \communications\calls\{call-id}</summary>
    public class CallRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAnswerCommand() {
            var command = new Command("answer");
            var builder = new ApiSdk.Communications.Calls.Item.Answer.AnswerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAudioRoutingGroupsCommand() {
            var command = new Command("audio-routing-groups");
            var builder = new ApiSdk.Communications.Calls.Item.AudioRoutingGroups.AudioRoutingGroupsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCancelMediaProcessingCommand() {
            var command = new Command("cancel-media-processing");
            var builder = new ApiSdk.Communications.Calls.Item.CancelMediaProcessing.CancelMediaProcessingRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChangeScreenSharingRoleCommand() {
            var command = new Command("change-screen-sharing-role");
            var builder = new ApiSdk.Communications.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRoleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property calls for communications
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property calls for communications";
            // Create options for all the parameters
            var callIdOption = new Option<string>("--call-id", description: "key: id of call") {
            };
            callIdOption.IsRequired = true;
            command.AddOption(callIdOption);
            command.SetHandler(async (string callId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, callIdOption);
            return command;
        }
        /// <summary>
        /// Get calls from communications
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get calls from communications";
            // Create options for all the parameters
            var callIdOption = new Option<string>("--call-id", description: "key: id of call") {
            };
            callIdOption.IsRequired = true;
            command.AddOption(callIdOption);
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
            command.SetHandler(async (string callId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, callIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        public Command BuildKeepAliveCommand() {
            var command = new Command("keep-alive");
            var builder = new ApiSdk.Communications.Calls.Item.KeepAlive.KeepAliveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMuteCommand() {
            var command = new Command("mute");
            var builder = new ApiSdk.Communications.Calls.Item.Mute.MuteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            var builder = new ApiSdk.Communications.Calls.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildParticipantsCommand() {
            var command = new Command("participants");
            var builder = new ApiSdk.Communications.Calls.Item.Participants.ParticipantsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildInviteCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property calls in communications
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property calls in communications";
            // Create options for all the parameters
            var callIdOption = new Option<string>("--call-id", description: "key: id of call") {
            };
            callIdOption.IsRequired = true;
            command.AddOption(callIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string callId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Call>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, callIdOption, bodyOption);
            return command;
        }
        public Command BuildPlayPromptCommand() {
            var command = new Command("play-prompt");
            var builder = new ApiSdk.Communications.Calls.Item.PlayPrompt.PlayPromptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRecordResponseCommand() {
            var command = new Command("record-response");
            var builder = new ApiSdk.Communications.Calls.Item.RecordResponse.RecordResponseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRedirectCommand() {
            var command = new Command("redirect");
            var builder = new ApiSdk.Communications.Calls.Item.Redirect.RedirectRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRejectCommand() {
            var command = new Command("reject");
            var builder = new ApiSdk.Communications.Calls.Item.Reject.RejectRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSubscribeToToneCommand() {
            var command = new Command("subscribe-to-tone");
            var builder = new ApiSdk.Communications.Calls.Item.SubscribeToTone.SubscribeToToneRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTransferCommand() {
            var command = new Command("transfer");
            var builder = new ApiSdk.Communications.Calls.Item.Transfer.TransferRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUnmuteCommand() {
            var command = new Command("unmute");
            var builder = new ApiSdk.Communications.Calls.Item.Unmute.UnmuteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUpdateRecordingStatusCommand() {
            var command = new Command("update-recording-status");
            var builder = new ApiSdk.Communications.Calls.Item.UpdateRecordingStatus.UpdateRecordingStatusRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new CallRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CallRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/calls/{call_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property calls for communications
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
        /// Get calls from communications
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
        /// Update the navigation property calls in communications
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Call body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Get calls from communications</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
