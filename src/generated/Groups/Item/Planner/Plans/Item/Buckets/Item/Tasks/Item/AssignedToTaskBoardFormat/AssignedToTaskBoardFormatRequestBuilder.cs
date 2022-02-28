using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.Groups.Item.Planner.Plans.Item.Buckets.Item.Tasks.Item.AssignedToTaskBoardFormat {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}\planner\plans\{plannerPlan-id}\buckets\{plannerBucket-id}\tasks\{plannerTask-id}\assignedToTaskBoardFormat</summary>
    public class AssignedToTaskBoardFormatRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var plannerPlanIdOption = new Option<string>("--planner-plan-id", description: "key: id of plannerPlan") {
            };
            plannerPlanIdOption.IsRequired = true;
            command.AddOption(plannerPlanIdOption);
            var plannerBucketIdOption = new Option<string>("--planner-bucket-id", description: "key: id of plannerBucket") {
            };
            plannerBucketIdOption.IsRequired = true;
            command.AddOption(plannerBucketIdOption);
            var plannerTaskIdOption = new Option<string>("--planner-task-id", description: "key: id of plannerTask") {
            };
            plannerTaskIdOption.IsRequired = true;
            command.AddOption(plannerTaskIdOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var plannerPlanId = (string) parameters[1];
                var plannerBucketId = (string) parameters[2];
                var plannerTaskId = (string) parameters[3];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("plannerPlan_id", plannerPlanId);
                PathParameters.Add("plannerBucket_id", plannerBucketId);
                PathParameters.Add("plannerTask_id", plannerTaskId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, plannerPlanIdOption, plannerBucketIdOption, plannerTaskIdOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var plannerPlanIdOption = new Option<string>("--planner-plan-id", description: "key: id of plannerPlan") {
            };
            plannerPlanIdOption.IsRequired = true;
            command.AddOption(plannerPlanIdOption);
            var plannerBucketIdOption = new Option<string>("--planner-bucket-id", description: "key: id of plannerBucket") {
            };
            plannerBucketIdOption.IsRequired = true;
            command.AddOption(plannerBucketIdOption);
            var plannerTaskIdOption = new Option<string>("--planner-task-id", description: "key: id of plannerTask") {
            };
            plannerTaskIdOption.IsRequired = true;
            command.AddOption(plannerTaskIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var plannerPlanId = (string) parameters[1];
                var plannerBucketId = (string) parameters[2];
                var plannerTaskId = (string) parameters[3];
                var select = (string[]) parameters[4];
                var expand = (string[]) parameters[5];
                var output = (FormatterType) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("plannerPlan_id", plannerPlanId);
                PathParameters.Add("plannerBucket_id", plannerBucketId);
                PathParameters.Add("plannerTask_id", plannerTaskId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(groupIdOption, plannerPlanIdOption, plannerBucketIdOption, plannerTaskIdOption, selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var plannerPlanIdOption = new Option<string>("--planner-plan-id", description: "key: id of plannerPlan") {
            };
            plannerPlanIdOption.IsRequired = true;
            command.AddOption(plannerPlanIdOption);
            var plannerBucketIdOption = new Option<string>("--planner-bucket-id", description: "key: id of plannerBucket") {
            };
            plannerBucketIdOption.IsRequired = true;
            command.AddOption(plannerBucketIdOption);
            var plannerTaskIdOption = new Option<string>("--planner-task-id", description: "key: id of plannerTask") {
            };
            plannerTaskIdOption.IsRequired = true;
            command.AddOption(plannerTaskIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var plannerPlanId = (string) parameters[1];
                var plannerBucketId = (string) parameters[2];
                var plannerTaskId = (string) parameters[3];
                var body = (string) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("plannerPlan_id", plannerPlanId);
                PathParameters.Add("plannerBucket_id", plannerBucketId);
                PathParameters.Add("plannerTask_id", plannerTaskId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<PlannerAssignedToTaskBoardTaskFormat>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, plannerPlanIdOption, plannerBucketIdOption, plannerTaskIdOption, bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new AssignedToTaskBoardFormatRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AssignedToTaskBoardFormatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/planner/plans/{plannerPlan_id}/buckets/{plannerBucket_id}/tasks/{plannerTask_id}/assignedToTaskBoardFormat{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
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
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
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
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(PlannerAssignedToTaskBoardTaskFormat body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
