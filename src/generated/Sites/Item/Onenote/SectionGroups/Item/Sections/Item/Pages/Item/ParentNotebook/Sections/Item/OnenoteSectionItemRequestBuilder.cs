using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook.Sections.Item.CopyToNotebook;
using ApiSdk.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook.Sections.Item.CopyToSectionGroup;
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
namespace ApiSdk.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook.Sections.Item {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\onenote\sectionGroups\{sectionGroup-id}\sections\{onenoteSection-id}\pages\{onenotePage-id}\parentNotebook\sections\{onenoteSection-id1}</summary>
    public class OnenoteSectionItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCopyToNotebookCommand() {
            var command = new Command("copy-to-notebook");
            var builder = new ApiSdk.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook.Sections.Item.CopyToNotebook.CopyToNotebookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCopyToSectionGroupCommand() {
            var command = new Command("copy-to-section-group");
            var builder = new ApiSdk.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.ParentNotebook.Sections.Item.CopyToSectionGroup.CopyToSectionGroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The sections in the notebook. Read-only. Nullable.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The sections in the notebook. Read-only. Nullable.";
            // Create options for all the parameters
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
            var onenoteSectionId1Option = new Option<string>("--onenote-section-id1", description: "key: id of onenoteSection") {
            };
            onenoteSectionId1Option.IsRequired = true;
            command.AddOption(onenoteSectionId1Option);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var sectionGroupId = (string) parameters[1];
                var onenoteSectionId = (string) parameters[2];
                var onenotePageId = (string) parameters[3];
                var onenoteSectionId1 = (string) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                PathParameters.Add("onenoteSection_id1", onenoteSectionId1);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, onenoteSectionId1Option, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The sections in the notebook. Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The sections in the notebook. Read-only. Nullable.";
            // Create options for all the parameters
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
            var onenoteSectionId1Option = new Option<string>("--onenote-section-id1", description: "key: id of onenoteSection") {
            };
            onenoteSectionId1Option.IsRequired = true;
            command.AddOption(onenoteSectionId1Option);
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
            var outputFilterOption = new Option<string>("--query");
            command.AddOption(outputFilterOption);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var sectionGroupId = (string) parameters[1];
                var onenoteSectionId = (string) parameters[2];
                var onenotePageId = (string) parameters[3];
                var onenoteSectionId1 = (string) parameters[4];
                var select = (string[]) parameters[5];
                var expand = (string[]) parameters[6];
                var output = (FormatterType) parameters[7];
                var outputFilterOption = (string) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                PathParameters.Add("onenoteSection_id1", onenoteSectionId1);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, onenoteSectionId1Option, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The sections in the notebook. Read-only. Nullable.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The sections in the notebook. Read-only. Nullable.";
            // Create options for all the parameters
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
            var onenoteSectionId1Option = new Option<string>("--onenote-section-id1", description: "key: id of onenoteSection") {
            };
            onenoteSectionId1Option.IsRequired = true;
            command.AddOption(onenoteSectionId1Option);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var sectionGroupId = (string) parameters[1];
                var onenoteSectionId = (string) parameters[2];
                var onenotePageId = (string) parameters[3];
                var onenoteSectionId1 = (string) parameters[4];
                var body = (string) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                PathParameters.Add("onenoteSection_id1", onenoteSectionId1);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<OnenoteSection>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, onenoteSectionId1Option, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new OnenoteSectionItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public OnenoteSectionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/onenote/sectionGroups/{sectionGroup_id}/sections/{onenoteSection_id}/pages/{onenotePage_id}/parentNotebook/sections/{onenoteSection_id1}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The sections in the notebook. Read-only. Nullable.
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
        /// The sections in the notebook. Read-only. Nullable.
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
        /// The sections in the notebook. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(OnenoteSection body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>The sections in the notebook. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
