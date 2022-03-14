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
namespace ApiSdk.Groups.Item.Onenote.Pages.Item.ParentNotebook.SectionGroups.Item.Sections.Item.Pages.Item.Preview {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}\onenote\pages\{onenotePage-id}\parentNotebook\sectionGroups\{sectionGroup-id}\sections\{onenoteSection-id}\pages\{onenotePage-id1}\microsoft.graph.preview()</summary>
    public class PreviewRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function preview
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function preview";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var sectionGroupIdOption = new Option<string>("--section-group-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageId1Option = new Option<string>("--onenote-page-id1", description: "key: id of onenotePage") {
            };
            onenotePageId1Option.IsRequired = true;
            command.AddOption(onenotePageId1Option);
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
                var onenotePageId = (string) parameters[1];
                var sectionGroupId = (string) parameters[2];
                var onenoteSectionId = (string) parameters[3];
                var onenotePageId1 = (string) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("onenotePage_id", onenotePageId);
                PathParameters.Add("sectionGroup_id", sectionGroupId);
                PathParameters.Add("onenoteSection_id", onenoteSectionId);
                PathParameters.Add("onenotePage_id1", onenotePageId1);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(groupIdOption, onenotePageIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageId1Option, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new PreviewRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PreviewRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/onenote/pages/{onenotePage_id}/parentNotebook/sectionGroups/{sectionGroup_id}/sections/{onenoteSection_id}/pages/{onenotePage_id1}/microsoft.graph.preview()";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function preview
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>Union type wrapper for classes onenotePagePreview</summary>
        public class PreviewResponse : IAdditionalDataHolder, IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type onenotePagePreview</summary>
            public ApiSdk.Models.Microsoft.Graph.OnenotePagePreview OnenotePagePreview { get; set; }
            /// <summary>
            /// Instantiates a new previewResponse and sets the default values.
            /// </summary>
            public PreviewResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            public static PreviewResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                return new PreviewResponse();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"onenotePagePreview", (o,n) => { (o as PreviewResponse).OnenotePagePreview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OnenotePagePreview>(ApiSdk.Models.Microsoft.Graph.OnenotePagePreview.CreateFromDiscriminatorValue); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OnenotePagePreview>("onenotePagePreview", OnenotePagePreview);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
