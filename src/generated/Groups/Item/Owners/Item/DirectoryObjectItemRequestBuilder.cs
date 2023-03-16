using ApiSdk.Groups.Item.Owners.Item.GraphApplication;
using ApiSdk.Groups.Item.Owners.Item.GraphDevice;
using ApiSdk.Groups.Item.Owners.Item.GraphGroup;
using ApiSdk.Groups.Item.Owners.Item.GraphOrgContact;
using ApiSdk.Groups.Item.Owners.Item.GraphServicePrincipal;
using ApiSdk.Groups.Item.Owners.Item.GraphUser;
using ApiSdk.Groups.Item.Owners.Item.Ref;
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
namespace ApiSdk.Groups.Item.Owners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \groups\{group-id}\owners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Casts the previous resource to application.
        /// </summary>
        public Command BuildGraphApplicationCommand() {
            var command = new Command("graph-application");
            command.Description = "Casts the previous resource to application.";
            var builder = new GraphApplicationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to device.
        /// </summary>
        public Command BuildGraphDeviceCommand() {
            var command = new Command("graph-device");
            command.Description = "Casts the previous resource to device.";
            var builder = new GraphDeviceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to group.
        /// </summary>
        public Command BuildGraphGroupCommand() {
            var command = new Command("graph-group");
            command.Description = "Casts the previous resource to group.";
            var builder = new GraphGroupRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to orgContact.
        /// </summary>
        public Command BuildGraphOrgContactCommand() {
            var command = new Command("graph-org-contact");
            command.Description = "Casts the previous resource to orgContact.";
            var builder = new GraphOrgContactRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildGraphServicePrincipalCommand() {
            var command = new Command("graph-service-principal");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new GraphServicePrincipalRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        public Command BuildGraphUserCommand() {
            var command = new Command("graph-user");
            command.Description = "Casts the previous resource to user.";
            var builder = new GraphUserRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of group entities.
        /// </summary>
        public Command BuildRefCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of group entities.";
            var builder = new RefRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}/owners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
