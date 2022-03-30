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
namespace ApiSdk.Drives.Item.Items.Item.Versions.Item.Content {
    /// <summary>Provides operations to manage the media for the drive entity.</summary>
    public class ContentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The content stream for this version of the item.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The content stream for this version of the item.";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "key: id of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var driveItemVersionIdOption = new Option<string>("--drive-item-version-id", description: "key: id of driveItemVersion") {
            };
            driveItemVersionIdOption.IsRequired = true;
            command.AddOption(driveItemVersionIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (object[] parameters) => {
                var driveId = (string) parameters[0];
                var driveItemId = (string) parameters[1];
                var driveItemVersionId = (string) parameters[2];
                var file = (FileInfo) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("drive_id", driveId);
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("driveItemVersion_id", driveItemVersionId);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                if (file == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {file.FullName}.");
                }
            }, new CollectionBinding(driveIdOption, driveItemIdOption, driveItemVersionIdOption, fileOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The content stream for this version of the item.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The content stream for this version of the item.";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "key: id of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var driveItemVersionIdOption = new Option<string>("--drive-item-version-id", description: "key: id of driveItemVersion") {
            };
            driveItemVersionIdOption.IsRequired = true;
            command.AddOption(driveItemVersionIdOption);
            var bodyOption = new Option<Stream>("--file", description: "Binary request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var driveId = (string) parameters[0];
                var driveItemId = (string) parameters[1];
                var driveItemVersionId = (string) parameters[2];
                var file = (FileInfo) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("drive_id", driveId);
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("driveItemVersion_id", driveItemVersionId);
                using var stream = file.OpenRead();
                var requestInfo = CreatePutRequestInformation(stream, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveIdOption, driveItemIdOption, driveItemVersionIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/drives/{drive_id}/items/{driveItem_id}/versions/{driveItemVersion_id}/content";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The content stream for this version of the item.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The content stream for this version of the item.
        /// <param name="body">Binary request body</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(Stream body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
    }
}
