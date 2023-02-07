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
namespace ApiSdk.Me.Authentication.PhoneMethods.Item.MicrosoftGraphDisableSmsSignIn {
    /// <summary>
    /// Provides operations to call the disableSmsSignIn method.
    /// </summary>
    public class MicrosoftGraphDisableSmsSignInRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Disable SMS sign-in for an existing `mobile` phone number registered to a user. The number will no longer be available for SMS sign-in, which can prevent your user from signing in.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/phoneauthenticationmethod-disablesmssignin?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Disable SMS sign-in for an existing `mobile` phone number registered to a user. The number will no longer be available for SMS sign-in, which can prevent your user from signing in.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/phoneauthenticationmethod-disablesmssignin?view=graph-rest-1.0";
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
        /// Instantiates a new MicrosoftGraphDisableSmsSignInRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphDisableSmsSignInRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me/authentication/phoneMethods/{phoneAuthenticationMethod%2Did}/microsoft.graph.disableSmsSignIn";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Disable SMS sign-in for an existing `mobile` phone number registered to a user. The number will no longer be available for SMS sign-in, which can prevent your user from signing in.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphDisableSmsSignInRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
