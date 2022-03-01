using ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest.Approve;
using ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest.Decline;
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
namespace ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest {
    /// <summary>Builds and executes requests for operations under \me\insights\used\{usedInsight-id}\resource\microsoft.graph.scheduleChangeRequest</summary>
    public class ScheduleChangeRequestRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApproveCommand() {
            var command = new Command("approve");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest.Approve.ApproveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeclineCommand() {
            var command = new Command("decline");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest.Decline.DeclineRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ScheduleChangeRequestRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ScheduleChangeRequestRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/used/{usedInsight_id}/resource/microsoft.graph.scheduleChangeRequest";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
