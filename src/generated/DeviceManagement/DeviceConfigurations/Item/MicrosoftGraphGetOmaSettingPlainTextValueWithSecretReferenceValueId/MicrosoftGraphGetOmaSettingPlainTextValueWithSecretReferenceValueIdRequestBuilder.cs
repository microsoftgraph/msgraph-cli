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
namespace ApiSdk.DeviceManagement.DeviceConfigurations.Item.MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueId {
    /// <summary>
    /// Provides operations to call the getOmaSettingPlainTextValue method.
    /// </summary>
    public class MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getOmaSettingPlainTextValue
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getOmaSettingPlainTextValue";
            // Create options for all the parameters
            var deviceConfigurationIdOption = new Option<string>("--device-configuration-id", description: "key: id of deviceConfiguration") {
            };
            deviceConfigurationIdOption.IsRequired = true;
            command.AddOption(deviceConfigurationIdOption);
            var secretReferenceValueIdOption = new Option<string>("--secret-reference-value-id", description: "Usage: secretReferenceValueId='{secretReferenceValueId}'") {
            };
            secretReferenceValueIdOption.IsRequired = true;
            command.AddOption(secretReferenceValueIdOption);
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
                var deviceConfigurationId = invocationContext.ParseResult.GetValueForOption(deviceConfigurationIdOption);
                var secretReferenceValueId = invocationContext.ParseResult.GetValueForOption(secretReferenceValueIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (deviceConfigurationId is not null) requestInfo.PathParameters.Add("deviceConfiguration%2Did", deviceConfigurationId);
                if (secretReferenceValueId is not null) requestInfo.PathParameters.Add("secretReferenceValueId", secretReferenceValueId);
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
        /// Instantiates a new MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="secretReferenceValueId">Usage: secretReferenceValueId=&apos;{secretReferenceValueId}&apos;</param>
        public MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(Dictionary<string, object> pathParameters, string secretReferenceValueId = "") {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration%2Did}/microsoft.graph.getOmaSettingPlainTextValue(secretReferenceValueId='{secretReferenceValueId}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            if (!string.IsNullOrWhiteSpace(secretReferenceValueId)) urlTplParams.Add("secretReferenceValueId", secretReferenceValueId);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Invoke function getOmaSettingPlainTextValue
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphGetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
