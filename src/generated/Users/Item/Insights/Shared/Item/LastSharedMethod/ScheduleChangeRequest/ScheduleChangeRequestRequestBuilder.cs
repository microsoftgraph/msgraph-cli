using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.Approve;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.Decline;
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
namespace ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.scheduleChangeRequest</summary>
    public class ScheduleChangeRequestRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApproveCommand() {
            var command = new Command("approve");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.Approve.ApproveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeclineCommand() {
            var command = new Command("decline");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.Decline.DeclineRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/shared/{sharedInsight_id}/lastSharedMethod/microsoft.graph.scheduleChangeRequest";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
