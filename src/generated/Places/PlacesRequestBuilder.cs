using ApiSdk.Places.Count;
using ApiSdk.Places.GraphRoom;
using ApiSdk.Places.Item;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Places {
    /// <summary>
    /// Builds and executes requests for operations under \places
    /// </summary>
    public class PlacesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the collection of place entities.
        /// </summary>
        public Command BuildCommand() {
            var command = new Command("item");
            var builder = new PlaceItemRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGraphRoomCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        public Command BuildCountCommand() {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to room.
        /// </summary>
        public Command BuildGraphRoomCommand() {
            var command = new Command("graph-room");
            command.Description = "Casts the previous resource to room.";
            var builder = new GraphRoomRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new PlacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PlacesRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/places";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
