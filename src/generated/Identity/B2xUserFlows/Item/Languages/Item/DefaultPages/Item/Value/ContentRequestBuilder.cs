using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Identity.B2xUserFlows.Item.Languages.Item.DefaultPages.Item.Value {
    /// <summary>Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\languages\{userFlowLanguageConfiguration-id}\defaultPages\{userFlowLanguagePage-id}\$value</summary>
    public class ContentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Get media content for the navigation property defaultPages from identity
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property defaultPages from identity";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "key: id of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "key: id of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (object[] parameters) => {
                var b2xIdentityUserFlowId = (string) parameters[0];
                var userFlowLanguageConfigurationId = (string) parameters[1];
                var userFlowLanguagePageId = (string) parameters[2];
                var file = (FileInfo) parameters[3];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                PathParameters.Add("userFlowLanguageConfiguration_id", userFlowLanguageConfigurationId);
                PathParameters.Add("userFlowLanguagePage_id", userFlowLanguagePageId);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                if (file == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.WriteLine("strContent");
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {file.FullName}.");
                }
            }, new CollectionBinding(b2xIdentityUserFlowIdOption, userFlowLanguageConfigurationIdOption, userFlowLanguagePageIdOption, fileOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property defaultPages in identity
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property defaultPages in identity";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "key: id of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "key: id of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var bodyOption = new Option<Stream>("--file", description: "Binary request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var b2xIdentityUserFlowId = (string) parameters[0];
                var userFlowLanguageConfigurationId = (string) parameters[1];
                var userFlowLanguagePageId = (string) parameters[2];
                var file = (FileInfo) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                PathParameters.Add("userFlowLanguageConfiguration_id", userFlowLanguageConfigurationId);
                PathParameters.Add("userFlowLanguagePage_id", userFlowLanguagePageId);
                using var stream = file.OpenRead();
                var requestInfo = CreatePutRequestInformation(stream, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(b2xIdentityUserFlowIdOption, userFlowLanguageConfigurationIdOption, userFlowLanguagePageIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
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
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow_id}/languages/{userFlowLanguageConfiguration_id}/defaultPages/{userFlowLanguagePage_id}/$value";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get media content for the navigation property defaultPages from identity
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
        /// Update media content for the navigation property defaultPages in identity
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
    }
}
