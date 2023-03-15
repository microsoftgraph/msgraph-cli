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
namespace ApiSdk.Identity.B2xUserFlows.Item.Languages.Item.OverridesPages.Item.Value {
    /// <summary>
    /// Provides operations to manage the media for the identityContainer entity.
    /// </summary>
    public class ContentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Get media content for the navigation property overridesPages from identity
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property overridesPages from identity\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "The unique identifier of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "The unique identifier of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "The unique identifier of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var b2xIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2xIdentityUserFlowIdOption);
                var userFlowLanguageConfigurationId = invocationContext.ParseResult.GetValueForOption(userFlowLanguageConfigurationIdOption);
                var userFlowLanguagePageId = invocationContext.ParseResult.GetValueForOption(userFlowLanguagePageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (b2xIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2xIdentityUserFlow%2Did", b2xIdentityUserFlowId);
                if (userFlowLanguageConfigurationId is not null) requestInfo.PathParameters.Add("userFlowLanguageConfiguration%2Did", userFlowLanguageConfigurationId);
                if (userFlowLanguagePageId is not null) requestInfo.PathParameters.Add("userFlowLanguagePage%2Did", userFlowLanguagePageId);
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
        /// Update media content for the navigation property overridesPages in identity
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property overridesPages in identity";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "The unique identifier of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "The unique identifier of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "The unique identifier of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var fileOption = new Option<FileInfo>("--file", description: "Binary request body") {
            };
            fileOption.IsRequired = true;
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var b2xIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2xIdentityUserFlowIdOption);
                var userFlowLanguageConfigurationId = invocationContext.ParseResult.GetValueForOption(userFlowLanguageConfigurationIdOption);
                var userFlowLanguagePageId = invocationContext.ParseResult.GetValueForOption(userFlowLanguagePageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (file is null || !file.Exists) return;
                using var stream = file.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (b2xIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2xIdentityUserFlow%2Did", b2xIdentityUserFlowId);
                if (userFlowLanguageConfigurationId is not null) requestInfo.PathParameters.Add("userFlowLanguageConfiguration%2Did", userFlowLanguageConfigurationId);
                if (userFlowLanguagePageId is not null) requestInfo.PathParameters.Add("userFlowLanguagePage%2Did", userFlowLanguagePageId);
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
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/languages/{userFlowLanguageConfiguration%2Did}/overridesPages/{userFlowLanguagePage%2Did}/$value";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Get media content for the navigation property overridesPages from identity
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ContentRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ContentRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ContentRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update media content for the navigation property overridesPages in identity
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<ContentRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<ContentRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
            if (requestConfiguration != null) {
                var requestConfig = new ContentRequestBuilderPutRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ContentRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ContentRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ContentRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ContentRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ContentRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public ContentRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
