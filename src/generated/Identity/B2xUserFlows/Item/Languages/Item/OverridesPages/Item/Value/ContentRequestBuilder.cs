using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
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
            // Create options for all the parameters
            command.AddOption(new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow"));
            command.AddOption(new Option<string>("--userflowlanguageconfiguration-id", description: "key: id of userFlowLanguageConfiguration"));
            command.AddOption(new Option<string>("--userflowlanguagepage-id", description: "key: id of userFlowLanguagePage"));
            command.AddOption(new Option<FileInfo>("--output"));
            command.Handler = CommandHandler.Create<string, string, string, FileInfo>(async (b2xIdentityUserFlowId, userFlowLanguageConfigurationId, userFlowLanguagePageId, output) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(b2xIdentityUserFlowId)) requestInfo.PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                if (!String.IsNullOrEmpty(userFlowLanguageConfigurationId)) requestInfo.PathParameters.Add("userFlowLanguageConfiguration_id", userFlowLanguageConfigurationId);
                if (!String.IsNullOrEmpty(userFlowLanguagePageId)) requestInfo.PathParameters.Add("userFlowLanguagePage_id", userFlowLanguagePageId);
                var result = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                // Print request output. What if the request has no return?
                if (output == null) {
                    using var reader = new StreamReader(result);
                    var strContent = await reader.ReadToEndAsync();
                    Console.Write(strContent + "\n");
                }
                else {
                    using var writeStream = output.OpenWrite();
                    await result.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {output.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property overridesPages in identity
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow"));
            command.AddOption(new Option<string>("--userflowlanguageconfiguration-id", description: "key: id of userFlowLanguageConfiguration"));
            command.AddOption(new Option<string>("--userflowlanguagepage-id", description: "key: id of userFlowLanguagePage"));
            command.AddOption(new Option<Stream>("--file", description: "Binary request body"));
            command.Handler = CommandHandler.Create<string, string, string, FileInfo>(async (b2xIdentityUserFlowId, userFlowLanguageConfigurationId, userFlowLanguagePageId, file) => {
                using var stream = file.OpenRead();
                var requestInfo = CreatePutRequestInformation(stream);
                if (!String.IsNullOrEmpty(b2xIdentityUserFlowId)) requestInfo.PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                if (!String.IsNullOrEmpty(userFlowLanguageConfigurationId)) requestInfo.PathParameters.Add("userFlowLanguageConfiguration_id", userFlowLanguageConfigurationId);
                if (!String.IsNullOrEmpty(userFlowLanguagePageId)) requestInfo.PathParameters.Add("userFlowLanguagePage_id", userFlowLanguagePageId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
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
        /// Get media content for the navigation property overridesPages from identity
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
                HttpMethod = HttpMethod.PUT,
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
