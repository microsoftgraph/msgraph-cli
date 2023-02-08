using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Item.Messages.Item.Attachments;
using ApiSdk.Users.Item.Messages.Item.Extensions;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphCopy;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphCreateForward;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphCreateReply;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphCreateReplyAll;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphForward;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphMove;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphReply;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphReplyAll;
using ApiSdk.Users.Item.Messages.Item.MicrosoftGraphSend;
using ApiSdk.Users.Item.Messages.Item.MultiValueExtendedProperties;
using ApiSdk.Users.Item.Messages.Item.SingleValueExtendedProperties;
using ApiSdk.Users.Item.Messages.Item.Value;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Messages.Item {
    /// <summary>
    /// Provides operations to manage the messages property of the microsoft.graph.user entity.
    /// </summary>
    public class MessageItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the attachments property of the microsoft.graph.message entity.
        /// </summary>
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            command.Description = "Provides operations to manage the attachments property of the microsoft.graph.message entity.";
            var builder = new AttachmentsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCreateUploadSessionCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the user entity.
        /// </summary>
        public Command BuildContentCommand() {
            var command = new Command("content");
            command.Description = "Provides operations to manage the media for the user entity.";
            var builder = new ContentRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property messages for users
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property messages for users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var messageId = invocationContext.ParseResult.GetValueForOption(messageIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (messageId is not null) requestInfo.PathParameters.Add("message%2Did", messageId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.message entity.
        /// </summary>
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.message entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The messages in a mailbox or folder. Read-only. Nullable.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
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
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var messageId = invocationContext.ParseResult.GetValueForOption(messageIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (messageId is not null) requestInfo.PathParameters.Add("message%2Did", messageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the copy method.
        /// </summary>
        public Command BuildMicrosoftGraphCopyCommand() {
            var command = new Command("microsoft-graph-copy");
            command.Description = "Provides operations to call the copy method.";
            var builder = new MicrosoftGraphCopyRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createForward method.
        /// </summary>
        public Command BuildMicrosoftGraphCreateForwardCommand() {
            var command = new Command("microsoft-graph-create-forward");
            command.Description = "Provides operations to call the createForward method.";
            var builder = new MicrosoftGraphCreateForwardRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createReplyAll method.
        /// </summary>
        public Command BuildMicrosoftGraphCreateReplyAllCommand() {
            var command = new Command("microsoft-graph-create-reply-all");
            command.Description = "Provides operations to call the createReplyAll method.";
            var builder = new MicrosoftGraphCreateReplyAllRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createReply method.
        /// </summary>
        public Command BuildMicrosoftGraphCreateReplyCommand() {
            var command = new Command("microsoft-graph-create-reply");
            command.Description = "Provides operations to call the createReply method.";
            var builder = new MicrosoftGraphCreateReplyRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the forward method.
        /// </summary>
        public Command BuildMicrosoftGraphForwardCommand() {
            var command = new Command("microsoft-graph-forward");
            command.Description = "Provides operations to call the forward method.";
            var builder = new MicrosoftGraphForwardRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the move method.
        /// </summary>
        public Command BuildMicrosoftGraphMoveCommand() {
            var command = new Command("microsoft-graph-move");
            command.Description = "Provides operations to call the move method.";
            var builder = new MicrosoftGraphMoveRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the replyAll method.
        /// </summary>
        public Command BuildMicrosoftGraphReplyAllCommand() {
            var command = new Command("microsoft-graph-reply-all");
            command.Description = "Provides operations to call the replyAll method.";
            var builder = new MicrosoftGraphReplyAllRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the reply method.
        /// </summary>
        public Command BuildMicrosoftGraphReplyCommand() {
            var command = new Command("microsoft-graph-reply");
            command.Description = "Provides operations to call the reply method.";
            var builder = new MicrosoftGraphReplyRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the send method.
        /// </summary>
        public Command BuildMicrosoftGraphSendCommand() {
            var command = new Command("microsoft-graph-send");
            command.Description = "Provides operations to call the send method.";
            var builder = new MicrosoftGraphSendRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.message entity.
        /// </summary>
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            command.Description = "Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.message entity.";
            var builder = new MultiValueExtendedPropertiesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property messages in users
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property messages in users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
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
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var messageId = invocationContext.ParseResult.GetValueForOption(messageIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Message>(ApiSdk.Models.Message.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (messageId is not null) requestInfo.PathParameters.Add("message%2Did", messageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.message entity.
        /// </summary>
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            command.Description = "Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.message entity.";
            var builder = new SingleValueExtendedPropertiesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MessageItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MessageItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/messages/{message%2Did}{?%24select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete navigation property messages for users
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<MessageItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<MessageItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MessageItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MessageItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MessageItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MessageItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property messages in users
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Message body, Action<MessageItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Message body, Action<MessageItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MessageItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MessageItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MessageItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public MessageItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// </summary>
        public class MessageItemRequestBuilderGetQueryParameters {
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MessageItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MessageItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MessageItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new MessageItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MessageItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MessageItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MessageItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public MessageItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
