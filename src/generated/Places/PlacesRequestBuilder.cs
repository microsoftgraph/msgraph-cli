using ApiSdk.Places.Count;
using ApiSdk.Places.GraphRoom;
using ApiSdk.Places.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons;
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
    public class PlacesRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of place entities.
        /// </summary>
        public Tuple<List<Command>, List<Command>> BuildCommand() {
            var executables = new List<Command>();
            var builder = new PlaceItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildPatchCommand());
            return new(executables, new(0));
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        public Command BuildCountNavCommand() {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to room.
        /// </summary>
        public Command BuildGraphRoomNavCommand() {
            var placeIndexer = new PlaceItemRequestBuilder(PathParameters);
            var command = placeIndexer.BuildGraphRoomNavCommand();
            command.Description = "Casts the previous resource to room.";
            var builder = new GraphRoomRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new PlacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PlacesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/places", pathParameters) {
        }
    }
}
