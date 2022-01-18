using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Sites.Item.Lists.Item.Items.Item.Versions.Item.RestoreVersion {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\lists\{list-id}\items\{listItem-id}\versions\{listItemVersion-id}\microsoft.graph.restoreVersion</summary>
    public class RestoreVersionRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action restoreVersion
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action restoreVersion";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site");
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var listIdOption = new Option<string>("--list-id", description: "key: id of list");
            listIdOption.IsRequired = true;
            command.AddOption(listIdOption);
            var listItemIdOption = new Option<string>("--listitem-id", description: "key: id of listItem");
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var listItemVersionIdOption = new Option<string>("--listitemversion-id", description: "key: id of listItemVersion");
            listItemVersionIdOption.IsRequired = true;
            command.AddOption(listItemVersionIdOption);
            command.Handler = CommandHandler.Create<string, string, string, string>(async (siteId, listId, listItemId, listItemVersionId) => {
                var requestInfo = CreatePostRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new RestoreVersionRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RestoreVersionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/lists/{list_id}/items/{listItem_id}/versions/{listItemVersion_id}/microsoft.graph.restoreVersion";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action restoreVersion
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke action restoreVersion
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PostAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreatePostRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}
