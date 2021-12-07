using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Outlook.MasterCategories;
using ApiSdk.Users.Item.Outlook.SupportedLanguages;
using ApiSdk.Users.Item.Outlook.SupportedTimeZones;
using ApiSdk.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Outlook {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\outlook</summary>
    public class OutlookRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--user-id", description: "key: id of user"));
            command.Handler = CommandHandler.Create<string>(async (userId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(userId)) requestInfo.PathParameters.Add("user_id", userId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--user-id", description: "key: id of user"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.Handler = CommandHandler.Create<string, object>(async (userId, select) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(userId)) requestInfo.PathParameters.Add("user_id", userId);
                requestInfo.QueryParameters.Add("select", select);
                var result = await RequestAdapter.SendAsync<OutlookUser>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        public Command BuildMasterCategoriesCommand() {
            var command = new Command("master-categories");
            var builder = new ApiSdk.Users.Item.Outlook.MasterCategories.MasterCategoriesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Read-only.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--user-id", description: "key: id of user"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string>(async (userId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<OutlookUser>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(userId)) requestInfo.PathParameters.Add("user_id", userId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new OutlookRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public OutlookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/outlook{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
        /// Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(OutlookUser body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<OutlookUser> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<OutlookUser>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(OutlookUser model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\outlook\microsoft.graph.supportedLanguages()
        /// </summary>
        public SupportedLanguagesRequestBuilder SupportedLanguages() {
            return new SupportedLanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\outlook\microsoft.graph.supportedTimeZones()
        /// </summary>
        public SupportedTimeZonesRequestBuilder SupportedTimeZones() {
            return new SupportedTimeZonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\outlook\microsoft.graph.supportedTimeZones(TimeZoneStandard={TimeZoneStandard})
        /// <param name="TimeZoneStandard">Usage: TimeZoneStandard={TimeZoneStandard}</param>
        /// </summary>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder SupportedTimeZonesWithTimeZoneStandard(string timeZoneStandard) {
            if(string.IsNullOrEmpty(timeZoneStandard)) throw new ArgumentNullException(nameof(timeZoneStandard));
            return new SupportedTimeZonesWithTimeZoneStandardRequestBuilder(PathParameters, RequestAdapter, timeZoneStandard);
        }
        /// <summary>Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
