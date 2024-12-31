// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.AttendanceRecords;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item
{
    /// <summary>
    /// Provides operations to manage the attendanceReports property of the microsoft.graph.onlineMeetingBase entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MeetingAttendanceReportItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the attendanceRecords property of the microsoft.graph.meetingAttendanceReport entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAttendanceRecordsNavCommand()
        {
            var command = new Command("attendance-records");
            command.Description = "Provides operations to manage the attendanceRecords property of the microsoft.graph.meetingAttendanceReport entity.";
            var builder = new global::ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.AttendanceRecords.AttendanceRecordsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property attendanceReports for solutions
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property attendanceReports for solutions";
            var virtualEventWebinarIdOption = new Option<string>("--virtual-event-webinar-id", description: "The unique identifier of virtualEventWebinar") {
            };
            virtualEventWebinarIdOption.IsRequired = true;
            command.AddOption(virtualEventWebinarIdOption);
            var virtualEventSessionIdOption = new Option<string>("--virtual-event-session-id", description: "The unique identifier of virtualEventSession") {
            };
            virtualEventSessionIdOption.IsRequired = true;
            command.AddOption(virtualEventSessionIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "The unique identifier of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var virtualEventWebinarId = invocationContext.ParseResult.GetValueForOption(virtualEventWebinarIdOption);
                var virtualEventSessionId = invocationContext.ParseResult.GetValueForOption(virtualEventSessionIdOption);
                var meetingAttendanceReportId = invocationContext.ParseResult.GetValueForOption(meetingAttendanceReportIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (virtualEventWebinarId is not null) requestInfo.PathParameters.Add("virtualEventWebinar%2Did", virtualEventWebinarId);
                if (virtualEventSessionId is not null) requestInfo.PathParameters.Add("virtualEventSession%2Did", virtualEventSessionId);
                if (meetingAttendanceReportId is not null) requestInfo.PathParameters.Add("meetingAttendanceReport%2Did", meetingAttendanceReportId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// Get the meetingAttendanceReport for an onlineMeeting or a virtualEvent. When an online meeting ends, an attendance report is generated for that session.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/meetingattendancereport-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the meetingAttendanceReport for an onlineMeeting or a virtualEvent. When an online meeting ends, an attendance report is generated for that session.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/meetingattendancereport-get?view=graph-rest-1.0";
            var virtualEventWebinarIdOption = new Option<string>("--virtual-event-webinar-id", description: "The unique identifier of virtualEventWebinar") {
            };
            virtualEventWebinarIdOption.IsRequired = true;
            command.AddOption(virtualEventWebinarIdOption);
            var virtualEventSessionIdOption = new Option<string>("--virtual-event-session-id", description: "The unique identifier of virtualEventSession") {
            };
            virtualEventSessionIdOption.IsRequired = true;
            command.AddOption(virtualEventSessionIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "The unique identifier of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var virtualEventWebinarId = invocationContext.ParseResult.GetValueForOption(virtualEventWebinarIdOption);
                var virtualEventSessionId = invocationContext.ParseResult.GetValueForOption(virtualEventSessionIdOption);
                var meetingAttendanceReportId = invocationContext.ParseResult.GetValueForOption(meetingAttendanceReportIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (virtualEventWebinarId is not null) requestInfo.PathParameters.Add("virtualEventWebinar%2Did", virtualEventWebinarId);
                if (virtualEventSessionId is not null) requestInfo.PathParameters.Add("virtualEventSession%2Did", virtualEventSessionId);
                if (meetingAttendanceReportId is not null) requestInfo.PathParameters.Add("meetingAttendanceReport%2Did", meetingAttendanceReportId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the navigation property attendanceReports in solutions
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property attendanceReports in solutions";
            var virtualEventWebinarIdOption = new Option<string>("--virtual-event-webinar-id", description: "The unique identifier of virtualEventWebinar") {
            };
            virtualEventWebinarIdOption.IsRequired = true;
            command.AddOption(virtualEventWebinarIdOption);
            var virtualEventSessionIdOption = new Option<string>("--virtual-event-session-id", description: "The unique identifier of virtualEventSession") {
            };
            virtualEventSessionIdOption.IsRequired = true;
            command.AddOption(virtualEventSessionIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "The unique identifier of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var virtualEventWebinarId = invocationContext.ParseResult.GetValueForOption(virtualEventWebinarIdOption);
                var virtualEventSessionId = invocationContext.ParseResult.GetValueForOption(virtualEventSessionIdOption);
                var meetingAttendanceReportId = invocationContext.ParseResult.GetValueForOption(meetingAttendanceReportIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.MeetingAttendanceReport>(global::ApiSdk.Models.MeetingAttendanceReport.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (virtualEventWebinarId is not null) requestInfo.PathParameters.Add("virtualEventWebinar%2Did", virtualEventWebinarId);
                if (virtualEventSessionId is not null) requestInfo.PathParameters.Add("virtualEventSession%2Did", virtualEventSessionId);
                if (meetingAttendanceReportId is not null) requestInfo.PathParameters.Add("meetingAttendanceReport%2Did", meetingAttendanceReportId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.MeetingAttendanceReportItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MeetingAttendanceReportItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}/attendanceReports/{meetingAttendanceReport%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.MeetingAttendanceReportItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MeetingAttendanceReportItemRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}/attendanceReports/{meetingAttendanceReport%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property attendanceReports for solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the meetingAttendanceReport for an onlineMeeting or a virtualEvent. When an online meeting ends, an attendance report is generated for that session.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.MeetingAttendanceReportItemRequestBuilder.MeetingAttendanceReportItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.Item.MeetingAttendanceReportItemRequestBuilder.MeetingAttendanceReportItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property attendanceReports in solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.MeetingAttendanceReport body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.MeetingAttendanceReport body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the meetingAttendanceReport for an onlineMeeting or a virtualEvent. When an online meeting ends, an attendance report is generated for that session.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MeetingAttendanceReportItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
