using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageAccountDetailWithDate {
    /// <summary>
    /// Provides operations to call the getOneDriveUsageAccountDetail method.
    /// </summary>
    public class MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getOneDriveUsageAccountDetail
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getOneDriveUsageAccountDetail";
            // Create options for all the parameters
            var dateOption = new Option<string>("--date", description: "Usage: date={date}") {
            };
            dateOption.IsRequired = true;
            command.AddOption(dateOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var date = invocationContext.ParseResult.GetValueForOption(dateOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (date is not null) requestInfo.PathParameters.Add("date", date);
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
        /// Instantiates a new MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilder(Dictionary<string, object> pathParameters, Date? date = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/reports/microsoft.graph.getOneDriveUsageAccountDetail(date={date})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            if (date is not null) urlTplParams.Add("date", date);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Invoke function getOneDriveUsageAccountDetail
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
