using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons;
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
namespace ApiSdk.Users.Item.MailFolders.Item.Messages.Item.Value {
    /// <summary>
    /// Provides operations to manage the media for the user entity.
    /// </summary>
    public class ContentRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Get media content for the navigation property messages from users
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/mailfolder-list-messages?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property messages from users\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/mailfolder-list-messages?view=graph-rest-1.0";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mail-folder-id", description: "The unique identifier of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "The unique identifier of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var mailFolderId = invocationContext.ParseResult.GetValueForOption(mailFolderIdOption);
                var messageId = invocationContext.ParseResult.GetValueForOption(messageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (mailFolderId is not null) requestInfo.PathParameters.Add("mailFolder%2Did", mailFolderId);
                if (messageId is not null) requestInfo.PathParameters.Add("message%2Did", messageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (file == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {file.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property messages in users
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property messages in users";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mail-folder-id", description: "The unique identifier of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var messageIdOption = new Option<string>("--message-id", description: "The unique identifier of message") {
            };
            messageIdOption.IsRequired = true;
            command.AddOption(messageIdOption);
            var fileOption = new Option<FileInfo>("--file", description: "Binary request body") {
            };
            fileOption.IsRequired = true;
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var mailFolderId = invocationContext.ParseResult.GetValueForOption(mailFolderIdOption);
                var messageId = invocationContext.ParseResult.GetValueForOption(messageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (file is null || !file.Exists) return;
                using var stream = file.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (mailFolderId is not null) requestInfo.PathParameters.Add("mailFolder%2Did", mailFolderId);
                if (messageId is not null) requestInfo.PathParameters.Add("message%2Did", messageId);
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
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/messages/{message%2Did}/$value", pathParameters) {
        }
        /// <summary>
        /// Get media content for the navigation property messages from users
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update media content for the navigation property messages in users
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
    }
}
