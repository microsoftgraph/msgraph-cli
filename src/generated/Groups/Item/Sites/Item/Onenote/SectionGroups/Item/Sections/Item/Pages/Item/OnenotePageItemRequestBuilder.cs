using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.Content;
using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.CopyToSection;
using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent;
using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook;
using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentSection;
using ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.Preview;
using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
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
namespace ApiSdk.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item {
    /// <summary>Provides operations to manage the pages property of the microsoft.graph.onenoteSection entity.</summary>
    public class OnenotePageItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildContentCommand() {
            var command = new Command("content");
            var builder = new ContentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildCopyToSectionCommand() {
            var command = new Command("copy-to-section");
            var builder = new CopyToSectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property pages for groups
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property pages for groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var sectionGroupIdOption = new Option<string>("--section-group-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var siteId = (string) parameters[1];
                var sectionGroupId = (string) parameters[2];
                var onenoteSectionId = (string) parameters[3];
                var onenotePageId = (string) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The collection of pages in the section.  Read-only. Nullable.";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var sectionGroupIdOption = new Option<string>("--section-group-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
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
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var siteId = (string) parameters[1];
                var sectionGroupId = (string) parameters[2];
                var onenoteSectionId = (string) parameters[3];
                var onenotePageId = (string) parameters[4];
                var select = (string[]) parameters[5];
                var expand = (string[]) parameters[6];
                var output = (FormatterType) parameters[7];
                var query = (string) parameters[8];
                var jsonNoIndent = (bool) parameters[9];
                var outputFilter = (IOutputFilter) parameters[10];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[11];
                var cancellationToken = (CancellationToken) parameters[12];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(groupIdOption, siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildOnenotePatchContentCommand() {
            var command = new Command("onenote-patch-content");
            var builder = new OnenotePatchContentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildParentNotebookCommand() {
            var command = new Command("parent-notebook");
            var builder = new ParentNotebookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildParentSectionCommand() {
            var command = new Command("parent-section");
            var builder = new ParentSectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property pages in groups
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property pages in groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var sectionGroupIdOption = new Option<string>("--section-group-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var siteId = (string) parameters[1];
                var sectionGroupId = (string) parameters[2];
                var onenoteSectionId = (string) parameters[3];
                var onenotePageId = (string) parameters[4];
                var body = (string) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<OnenotePage>(OnenotePage.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new OnenotePageItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public OnenotePageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}/onenote/sectionGroups/{sectionGroup_id}/sections/{onenoteSection_id}/pages/{onenotePage_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property pages for groups
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property pages in groups
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(OnenotePage body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the preview method.
        /// </summary>
        public PreviewRequestBuilder Preview() {
            return new PreviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
