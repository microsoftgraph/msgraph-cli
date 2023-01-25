using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.Application;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.Device;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.Group;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.OrgContact;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.Ref;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.ServicePrincipal;
using ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item.User;
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
namespace ApiSdk.DirectoryNamespace.AdministrativeUnits.Item.Members.Item {
    /// <summary>
    /// Builds and executes requests for operations under \directory\administrativeUnits\{administrativeUnit-id}\members\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Casts the previous resource to application.
        /// </summary>
        public Command BuildApplicationCommand() {
            var command = new Command("application");
            command.Description = "Casts the previous resource to application.";
            var builder = new ApplicationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to device.
        /// </summary>
        public Command BuildDeviceCommand() {
            var command = new Command("device");
            command.Description = "Casts the previous resource to device.";
            var builder = new DeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to group.
        /// </summary>
        public Command BuildGroupCommand() {
            var command = new Command("group");
            command.Description = "Casts the previous resource to group.";
            var builder = new GroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to orgContact.
        /// </summary>
        public Command BuildOrgContactCommand() {
            var command = new Command("org-contact");
            command.Description = "Casts the previous resource to orgContact.";
            var builder = new OrgContactRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directory entities.
        /// </summary>
        public Command BuildRefCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of directory entities.";
            var builder = new RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildServicePrincipalCommand() {
            var command = new Command("service-principal");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new ServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        public Command BuildUserCommand() {
            var command = new Command("user");
            command.Description = "Casts the previous resource to user.";
            var builder = new UserRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/directory/administrativeUnits/{administrativeUnit%2Did}/members/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
