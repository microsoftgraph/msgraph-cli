using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.AutofitColumns;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.AutofitRows;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.workbookRangeFormat</summary>
    public class WorkbookRangeFormatRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAutofitColumnsCommand() {
            var command = new Command("autofit-columns");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.AutofitColumns.AutofitColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAutofitRowsCommand() {
            var command = new Command("autofit-rows");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.AutofitRows.AutofitRowsRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod/microsoft.graph.workbookRangeFormat";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
