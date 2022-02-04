using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Identity.B2xUserFlows.Item.Languages.Item.OverridesPages.Item.Value {
    /// <summary>Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\languages\{userFlowLanguageConfiguration-id}\overridesPages\{userFlowLanguagePage-id}\$value</summary>
    public class ContentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Get media content for the navigation property overridesPages from identity
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property overridesPages from identity";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--userflowlanguageconfiguration-id", description: "key: id of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--userflowlanguagepage-id", description: "key: id of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string b2xIdentityUserFlowId, string userFlowLanguageConfigurationId, string userFlowLanguagePageId, FileInfo file, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                if (file == null) {
                    formatter.WriteOutput(response, console);
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    console.WriteLine($"Content written to {file.FullName}.");
                }
            }, b2xIdentityUserFlowIdOption, userFlowLanguageConfigurationIdOption, userFlowLanguagePageIdOption, fileOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property overridesPages in identity
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property overridesPages in identity";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--userflowlanguageconfiguration-id", description: "key: id of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--userflowlanguagepage-id", description: "key: id of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var bodyOption = new Option<Stream>("--file", description: "Binary request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string b2xIdentityUserFlowId, string userFlowLanguageConfigurationId, string userFlowLanguagePageId, FileInfo file, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = file.OpenRead();
                var requestInfo = CreatePutRequestInformation(stream, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, b2xIdentityUserFlowIdOption, userFlowLanguageConfigurationIdOption, userFlowLanguagePageIdOption, bodyOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow_id}/languages/{userFlowLanguageConfiguration_id}/overridesPages/{userFlowLanguagePage_id}/$value";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ContentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow_id}/languages/{userFlowLanguageConfiguration_id}/overridesPages/{userFlowLanguagePage_id}/$value";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get media content for the navigation property overridesPages from identity
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update media content for the navigation property overridesPages in identity
        /// <param name="body">Binary request body</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(Stream body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get media content for the navigation property overridesPages from identity
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Stream> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update media content for the navigation property overridesPages in identity
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// <param name="stream">Binary request body</param>
        /// </summary>
        public async Task PutAsync(Stream stream, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = stream ?? throw new ArgumentNullException(nameof(stream));
            var requestInfo = CreatePutRequestInformation(stream, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}
