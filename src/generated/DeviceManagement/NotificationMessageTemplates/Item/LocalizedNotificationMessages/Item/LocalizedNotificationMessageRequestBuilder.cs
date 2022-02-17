using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement.NotificationMessageTemplates.Item.LocalizedNotificationMessages.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\notificationMessageTemplates\{notificationMessageTemplate-id}\localizedNotificationMessages\{localizedNotificationMessage-id}</summary>
    public class LocalizedNotificationMessageRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The list of localized messages for this Notification Message Template.";
            // Create options for all the parameters
            var notificationMessageTemplateIdOption = new Option<string>("--notification-message-template-id", description: "key: id of notificationMessageTemplate") {
            };
            notificationMessageTemplateIdOption.IsRequired = true;
            command.AddOption(notificationMessageTemplateIdOption);
            var localizedNotificationMessageIdOption = new Option<string>("--localized-notification-message-id", description: "key: id of localizedNotificationMessage") {
            };
            localizedNotificationMessageIdOption.IsRequired = true;
            command.AddOption(localizedNotificationMessageIdOption);
            command.SetHandler(async (string notificationMessageTemplateId, string localizedNotificationMessageId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, notificationMessageTemplateIdOption, localizedNotificationMessageIdOption);
            return command;
        }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of localized messages for this Notification Message Template.";
            // Create options for all the parameters
            var notificationMessageTemplateIdOption = new Option<string>("--notification-message-template-id", description: "key: id of notificationMessageTemplate") {
            };
            notificationMessageTemplateIdOption.IsRequired = true;
            command.AddOption(notificationMessageTemplateIdOption);
            var localizedNotificationMessageIdOption = new Option<string>("--localized-notification-message-id", description: "key: id of localizedNotificationMessage") {
            };
            localizedNotificationMessageIdOption.IsRequired = true;
            command.AddOption(localizedNotificationMessageIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string notificationMessageTemplateId, string localizedNotificationMessageId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, notificationMessageTemplateIdOption, localizedNotificationMessageIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The list of localized messages for this Notification Message Template.";
            // Create options for all the parameters
            var notificationMessageTemplateIdOption = new Option<string>("--notification-message-template-id", description: "key: id of notificationMessageTemplate") {
            };
            notificationMessageTemplateIdOption.IsRequired = true;
            command.AddOption(notificationMessageTemplateIdOption);
            var localizedNotificationMessageIdOption = new Option<string>("--localized-notification-message-id", description: "key: id of localizedNotificationMessage") {
            };
            localizedNotificationMessageIdOption.IsRequired = true;
            command.AddOption(localizedNotificationMessageIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string notificationMessageTemplateId, string localizedNotificationMessageId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<LocalizedNotificationMessage>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, notificationMessageTemplateIdOption, localizedNotificationMessageIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new LocalizedNotificationMessageRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public LocalizedNotificationMessageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/notificationMessageTemplates/{notificationMessageTemplate_id}/localizedNotificationMessages/{localizedNotificationMessage_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The list of localized messages for this Notification Message Template.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(LocalizedNotificationMessage body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>The list of localized messages for this Notification Message Template.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
