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
namespace ApiSdk.DeviceManagement.RemoteAssistancePartners.Item.Disconnect {
    /// <summary>Builds and executes requests for operations under \deviceManagement\remoteAssistancePartners\{remoteAssistancePartner-id}\microsoft.graph.disconnect</summary>
    public class DisconnectRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// A request to remove the active TeamViewer connector
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "A request to remove the active TeamViewer connector";
            // Create options for all the parameters
            var remoteAssistancePartnerIdOption = new Option<string>("--remote-assistance-partner-id", description: "key: id of remoteAssistancePartner") {
            };
            remoteAssistancePartnerIdOption.IsRequired = true;
            command.AddOption(remoteAssistancePartnerIdOption);
            command.SetHandler(async (object[] parameters) => {
                var remoteAssistancePartnerId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("remoteAssistancePartner_id", remoteAssistancePartnerId);
                var requestInfo = CreatePostRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(remoteAssistancePartnerIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new DisconnectRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DisconnectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/remoteAssistancePartners/{remoteAssistancePartner_id}/microsoft.graph.disconnect";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// A request to remove the active TeamViewer connector
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
    }
}
