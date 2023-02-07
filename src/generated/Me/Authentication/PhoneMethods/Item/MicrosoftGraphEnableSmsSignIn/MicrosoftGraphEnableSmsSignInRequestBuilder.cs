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
namespace ApiSdk.Me.Authentication.PhoneMethods.Item.MicrosoftGraphEnableSmsSignIn {
    /// <summary>
    /// Provides operations to call the enableSmsSignIn method.
    /// </summary>
    public class MicrosoftGraphEnableSmsSignInRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Enable SMS sign-in for an existing `mobile` phone number registered to a user. To be successfully enabled:
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/phoneauthenticationmethod-enablesmssignin?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Enable SMS sign-in for an existing `mobile` phone number registered to a user. To be successfully enabled:\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/phoneauthenticationmethod-enablesmssignin?view=graph-rest-1.0";
            // Create options for all the parameters
            var phoneAuthenticationMethodIdOption = new Option<string>("--phone-authentication-method-id", description: "key: id of phoneAuthenticationMethod") {
            };
            phoneAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(phoneAuthenticationMethodIdOption);
            command.SetHandler(async (invocationContext) => {
                var phoneAuthenticationMethodId = invocationContext.ParseResult.GetValueForOption(phoneAuthenticationMethodIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (phoneAuthenticationMethodId is not null) requestInfo.PathParameters.Add("phoneAuthenticationMethod%2Did", phoneAuthenticationMethodId);
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
        /// Instantiates a new MicrosoftGraphEnableSmsSignInRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphEnableSmsSignInRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me/authentication/phoneMethods/{phoneAuthenticationMethod%2Did}/microsoft.graph.enableSmsSignIn";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Enable SMS sign-in for an existing `mobile` phone number registered to a user. To be successfully enabled:
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphEnableSmsSignInRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
