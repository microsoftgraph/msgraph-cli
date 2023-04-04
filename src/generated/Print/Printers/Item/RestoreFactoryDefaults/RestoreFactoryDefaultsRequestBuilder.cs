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
namespace ApiSdk.Print.Printers.Item.RestoreFactoryDefaults {
    /// <summary>
    /// Provides operations to call the restoreFactoryDefaults method.
    /// </summary>
    public class RestoreFactoryDefaultsRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Restore a printer&apos;s default settings to the values specified by the manufacturer.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/printer-restorefactorydefaults?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Restore a printer's default settings to the values specified by the manufacturer.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/printer-restorefactorydefaults?view=graph-rest-1.0";
            var printerIdOption = new Option<string>("--printer-id", description: "The unique identifier of printer") {
            };
            printerIdOption.IsRequired = true;
            command.AddOption(printerIdOption);
            command.SetHandler(async (invocationContext) => {
                var printerId = invocationContext.ParseResult.GetValueForOption(printerIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (printerId is not null) requestInfo.PathParameters.Add("printer%2Did", printerId);
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
        /// Instantiates a new RestoreFactoryDefaultsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RestoreFactoryDefaultsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printers/{printer%2Did}/restoreFactoryDefaults", pathParameters) {
        }
        /// <summary>
        /// Restore a printer&apos;s default settings to the values specified by the manufacturer.
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
