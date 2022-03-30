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
namespace ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.Attachments.CreateUploadSession {
    /// <summary>Provides operations to call the createUploadSession method.</summary>
    public class CreateUploadSessionRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action createUploadSession
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action createUploadSession";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mail-folder-id", description: "key: id of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var mailFolderId1Option = new Option<string>("--mail-folder-id1", description: "key: id of mailFolder") {
            };
            mailFolderId1Option.IsRequired = true;
            command.AddOption(mailFolderId1Option);
            var messageIdOption = new Option<string>("--message-id", description: "key: id of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
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
                var userId = (string) parameters[0];
                var mailFolderId = (string) parameters[1];
                var mailFolderId1 = (string) parameters[2];
                var messageId = (string) parameters[3];
                var body = (string) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("user_id", userId);
                PathParameters.Add("mailFolder_id", mailFolderId);
                PathParameters.Add("mailFolder_id1", mailFolderId1);
                PathParameters.Add("message_id", messageId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.Attachments.CreateUploadSession.CreateUploadSessionRequestBody>(ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.Attachments.CreateUploadSession.CreateUploadSessionRequestBody.CreateFromDiscriminatorValue);
                var requestInfo = CreatePostRequestInformation(model, q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(userIdOption, mailFolderIdOption, mailFolderId1Option, messageIdOption, bodyOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new CreateUploadSessionRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CreateUploadSessionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/mailFolders/{mailFolder_id}/childFolders/{mailFolder_id1}/messages/{message_id}/attachments/microsoft.graph.createUploadSession";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action createUploadSession
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.Attachments.CreateUploadSession.CreateUploadSessionRequestBody body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
    }
}
