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
namespace ApiSdk.Solutions.BookingBusinesses.Item.Publish {
    /// <summary>
    /// Provides operations to call the publish method.
    /// </summary>
    public class PublishRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Make the scheduling page of a business available to external customers. Set the **isPublished** property to `true`, and the **publicUrl** property to the URL of the scheduling page.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/bookingbusiness-publish?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Make the scheduling page of a business available to external customers. Set the **isPublished** property to `true`, and the **publicUrl** property to the URL of the scheduling page.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/bookingbusiness-publish?view=graph-rest-1.0";
            var bookingBusinessIdOption = new Option<string>("--booking-business-id", description: "The unique identifier of bookingBusiness") {
            };
            bookingBusinessIdOption.IsRequired = true;
            command.AddOption(bookingBusinessIdOption);
            command.SetHandler(async (invocationContext) => {
                var bookingBusinessId = invocationContext.ParseResult.GetValueForOption(bookingBusinessIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (bookingBusinessId is not null) requestInfo.PathParameters.Add("bookingBusiness%2Did", bookingBusinessId);
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
        /// Instantiates a new PublishRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PublishRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/publish", pathParameters) {
        }
        /// <summary>
        /// Make the scheduling page of a business available to external customers. Set the **isPublished** property to `true`, and the **publicUrl** property to the URL of the scheduling page.
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
