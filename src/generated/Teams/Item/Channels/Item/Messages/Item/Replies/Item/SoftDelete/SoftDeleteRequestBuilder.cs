using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Teams.Item.Channels.Item.Messages.Item.Replies.Item.SoftDelete {
    /// <summary>
    /// Provides operations to call the softDelete method.
    /// </summary>
    public class SoftDeleteRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke action softDelete
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action softDelete";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "The unique identifier of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "The unique identifier of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var channelId = invocationContext.ParseResult.GetValueForOption(channelIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var chatMessageId1 = invocationContext.ParseResult.GetValueForOption(chatMessageId1Option);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (channelId is not null) requestInfo.PathParameters.Add("channel%2Did", channelId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
                if (chatMessageId1 is not null) requestInfo.PathParameters.Add("chatMessage%2Did1", chatMessageId1);
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
        /// Instantiates a new SoftDeleteRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SoftDeleteRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teams/{team%2Did}/channels/{channel%2Did}/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/softDelete", pathParameters) {
        }
        /// <summary>
        /// Invoke action softDelete
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
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
    }
}
