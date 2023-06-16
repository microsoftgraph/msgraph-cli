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
namespace ApiSdk.Print.Printers.Item.Jobs.Item.Cancel {
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    public class CancelRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Cancel a print job. Print jobs can be canceled only on behalf of a user, using delegated permissions.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/printjob-cancel?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Cancel a print job. Print jobs can be canceled only on behalf of a user, using delegated permissions.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/printjob-cancel?view=graph-rest-1.0";
            var printerIdOption = new Option<string>("--printer-id", description: "The unique identifier of printer") {
            };
            printerIdOption.IsRequired = true;
            command.AddOption(printerIdOption);
            var printJobIdOption = new Option<string>("--print-job-id", description: "The unique identifier of printJob") {
            };
            printJobIdOption.IsRequired = true;
            command.AddOption(printJobIdOption);
            command.SetHandler(async (invocationContext) => {
                var printerId = invocationContext.ParseResult.GetValueForOption(printerIdOption);
                var printJobId = invocationContext.ParseResult.GetValueForOption(printJobIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (printerId is not null) requestInfo.PathParameters.Add("printer%2Did", printerId);
                if (printJobId is not null) requestInfo.PathParameters.Add("printJob%2Did", printJobId);
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
        /// Instantiates a new CancelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CancelRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printers/{printer%2Did}/jobs/{printJob%2Did}/cancel", pathParameters) {
        }
        /// <summary>
        /// Cancel a print job. Print jobs can be canceled only on behalf of a user, using delegated permissions.
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
