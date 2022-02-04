using ApiSdk.Users.Item.Insights.Used.Item.Resource.WorkbookRangeFormat.AutofitColumns;
using ApiSdk.Users.Item.Insights.Used.Item.Resource.WorkbookRangeFormat.AutofitRows;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Used.Item.Resource.WorkbookRangeFormat {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\used\{usedInsight-id}\resource\microsoft.graph.workbookRangeFormat</summary>
    public class WorkbookRangeFormatRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAutofitColumnsCommand() {
            var command = new Command("autofit-columns");
            var builder = new ApiSdk.Users.Item.Insights.Used.Item.Resource.WorkbookRangeFormat.AutofitColumns.AutofitColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAutofitRowsCommand() {
            var command = new Command("autofit-rows");
            var builder = new ApiSdk.Users.Item.Insights.Used.Item.Resource.WorkbookRangeFormat.AutofitRows.AutofitRowsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeFormatRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeFormatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.workbookRangeFormat";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeFormatRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeFormatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.workbookRangeFormat";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
