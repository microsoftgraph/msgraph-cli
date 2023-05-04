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
namespace ApiSdk.Drives.Item.List.Items.Item.Versions.Item.RestoreVersion {
    /// <summary>
    /// Provides operations to call the restoreVersion method.
    /// </summary>
    public class RestoreVersionRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke action restoreVersion
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action restoreVersion";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var listItemIdOption = new Option<string>("--list-item-id", description: "The unique identifier of listItem") {
            };
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var listItemVersionIdOption = new Option<string>("--list-item-version-id", description: "The unique identifier of listItemVersion") {
            };
            listItemVersionIdOption.IsRequired = true;
            command.AddOption(listItemVersionIdOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var listItemVersionId = invocationContext.ParseResult.GetValueForOption(listItemVersionIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (listItemVersionId is not null) requestInfo.PathParameters.Add("listItemVersion%2Did", listItemVersionId);
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
        /// Instantiates a new RestoreVersionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RestoreVersionRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/list/items/{listItem%2Did}/versions/{listItemVersion%2Did}/restoreVersion", pathParameters) {
        }
        /// <summary>
        /// Invoke action restoreVersion
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
