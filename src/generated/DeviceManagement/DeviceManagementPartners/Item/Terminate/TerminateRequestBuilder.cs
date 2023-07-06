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
namespace ApiSdk.DeviceManagement.DeviceManagementPartners.Item.Terminate {
    /// <summary>
    /// Provides operations to call the terminate method.
    /// </summary>
    public class TerminateRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Not yet documented
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-onboarding-devicemanagementpartner-terminate?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Not yet documented\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/intune-onboarding-devicemanagementpartner-terminate?view=graph-rest-1.0";
            var deviceManagementPartnerIdOption = new Option<string>("--device-management-partner-id", description: "The unique identifier of deviceManagementPartner") {
            };
            deviceManagementPartnerIdOption.IsRequired = true;
            command.AddOption(deviceManagementPartnerIdOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementPartnerId = invocationContext.ParseResult.GetValueForOption(deviceManagementPartnerIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (deviceManagementPartnerId is not null) requestInfo.PathParameters.Add("deviceManagementPartner%2Did", deviceManagementPartnerId);
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
        /// Instantiates a new TerminateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TerminateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/deviceManagementPartners/{deviceManagementPartner%2Did}/terminate", pathParameters) {
        }
        /// <summary>
        /// Not yet documented
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
