using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Attachments;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CalendarSharingMessage;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Copy;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateForward;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateReply;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateReplyAll;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Extensions;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Forward;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Move;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.MultiValueExtendedProperties;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Reply;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.ReplyAll;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Send;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.SingleValueExtendedProperties;
using ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Value;
using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.MailFolders.Item.Messages.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\mailFolders\{mailFolder-id}\messages\{message-id}</summary>
    public class MessageRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarSharingMessageCommand() {
            var command = new Command("calendar-sharing-message");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CalendarSharingMessage.CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAcceptCommand());
            return command;
        }
        public Command BuildContentCommand() {
            var command = new Command("content");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Value.ContentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildCopyCommand() {
            var command = new Command("copy");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Copy.CopyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCreateForwardCommand() {
            var command = new Command("create-forward");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateForward.CreateForwardRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCreateReplyAllCommand() {
            var command = new Command("create-reply-all");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateReplyAll.CreateReplyAllRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCreateReplyCommand() {
            var command = new Command("create-reply");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateReply.CreateReplyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The collection of messages in the mailFolder.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mailfolder-id", description: "key: id of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            command.SetHandler(async (string userId, string mailFolderId, string messageId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, userIdOption, mailFolderIdOption, messageIdOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildForwardCommand() {
            var command = new Command("forward");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The collection of messages in the mailFolder.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mailfolder-id", description: "key: id of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
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
            command.SetHandler(async (string userId, string mailFolderId, string messageId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, userIdOption, mailFolderIdOption, messageIdOption, selectOption, expandOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildMoveCommand() {
            var command = new Command("move");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Move.MoveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.MultiValueExtendedProperties.MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The collection of messages in the mailFolder.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mailfolder-id", description: "key: id of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string userId, string mailFolderId, string messageId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Message>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, userIdOption, mailFolderIdOption, messageIdOption, bodyOption, new OutputFormatterFactoryBinder());
            return command;
        }
        public Command BuildReplyAllCommand() {
            var command = new Command("reply-all");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.ReplyAll.ReplyAllRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReplyCommand() {
            var command = new Command("reply");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Reply.ReplyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSendCommand() {
            var command = new Command("send");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Send.SendRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            var builder = new ApiSdk.Users.Item.MailFolders.Item.Messages.Item.SingleValueExtendedProperties.SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/mailFolders/{mailFolder_id}/messages/{message_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/mailFolders/{mailFolder_id}/messages/{message_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
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
        /// The collection of messages in the mailFolder.
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
        /// The collection of messages in the mailFolder.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Message> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Message>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Message model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The collection of messages in the mailFolder.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
