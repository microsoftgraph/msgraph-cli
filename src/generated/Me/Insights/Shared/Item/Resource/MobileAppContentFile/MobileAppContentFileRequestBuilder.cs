using ApiSdk.Me.Insights.Shared.Item.Resource.MobileAppContentFile.Commit;
using ApiSdk.Me.Insights.Shared.Item.Resource.MobileAppContentFile.RenewUpload;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Shared.Item.Resource.MobileAppContentFile {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\resource\microsoft.graph.mobileAppContentFile</summary>
    public class MobileAppContentFileRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCommitCommand() {
            var command = new Command("commit");
            var builder = new ApiSdk.Me.Insights.Shared.Item.Resource.MobileAppContentFile.Commit.CommitRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRenewUploadCommand() {
            var command = new Command("renew-upload");
            var builder = new ApiSdk.Me.Insights.Shared.Item.Resource.MobileAppContentFile.RenewUpload.RenewUploadRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MobileAppContentFileRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MobileAppContentFileRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/resource/microsoft.graph.mobileAppContentFile";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
