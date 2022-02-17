using ApiSdk.Me.MailFolders.Item.Messages.Item.CalendarSharingMessage.Accept;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Me.MailFolders.Item.Messages.Item.CalendarSharingMessage {
    /// <summary>Builds and executes requests for operations under \me\mailFolders\{mailFolder-id}\messages\{message-id}\microsoft.graph.calendarSharingMessage</summary>
    public class CalendarSharingMessageRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAcceptCommand() {
            var command = new Command("accept");
            var builder = new ApiSdk.Me.MailFolders.Item.Messages.Item.CalendarSharingMessage.Accept.AcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new CalendarSharingMessageRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CalendarSharingMessageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/mailFolders/{mailFolder_id}/messages/{message_id}/microsoft.graph.calendarSharingMessage";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
