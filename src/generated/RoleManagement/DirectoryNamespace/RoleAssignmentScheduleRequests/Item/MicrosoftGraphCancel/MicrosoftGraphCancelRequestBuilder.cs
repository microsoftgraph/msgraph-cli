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
namespace ApiSdk.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleRequests.Item.MicrosoftGraphCancel {
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    public class MicrosoftGraphCancelRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days. After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/unifiedroleassignmentschedulerequest-cancel?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days. After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/unifiedroleassignmentschedulerequest-cancel?view=graph-rest-1.0";
            // Create options for all the parameters
            var unifiedRoleAssignmentScheduleRequestIdOption = new Option<string>("--unified-role-assignment-schedule-request-id", description: "key: id of unifiedRoleAssignmentScheduleRequest") {
            };
            unifiedRoleAssignmentScheduleRequestIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentScheduleRequestIdOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleAssignmentScheduleRequestId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentScheduleRequestIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (unifiedRoleAssignmentScheduleRequestId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignmentScheduleRequest%2Did", unifiedRoleAssignmentScheduleRequestId);
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
        /// Instantiates a new MicrosoftGraphCancelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphCancelRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/roleManagement/directory/roleAssignmentScheduleRequests/{unifiedRoleAssignmentScheduleRequest%2Did}/microsoft.graph.cancel";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days. After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphCancelRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphCancelRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphCancelRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphCancelRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphCancelRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphCancelRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}