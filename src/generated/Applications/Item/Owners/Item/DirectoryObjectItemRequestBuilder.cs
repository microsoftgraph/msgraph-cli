using ApiSdk.Applications.Item.Owners.Item.MicrosoftGraphAppRoleAssignment;
using ApiSdk.Applications.Item.Owners.Item.MicrosoftGraphEndpoint;
using ApiSdk.Applications.Item.Owners.Item.MicrosoftGraphServicePrincipal;
using ApiSdk.Applications.Item.Owners.Item.MicrosoftGraphUser;
using ApiSdk.Applications.Item.Owners.Item.Ref;
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
namespace ApiSdk.Applications.Item.Owners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\owners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Casts the previous resource to appRoleAssignment.
        /// </summary>
        public Command BuildMicrosoftGraphAppRoleAssignmentCommand() {
            var command = new Command("microsoft-graph-app-role-assignment");
            command.Description = "Casts the previous resource to appRoleAssignment.";
            var builder = new MicrosoftGraphAppRoleAssignmentRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to endpoint.
        /// </summary>
        public Command BuildMicrosoftGraphEndpointCommand() {
            var command = new Command("microsoft-graph-endpoint");
            command.Description = "Casts the previous resource to endpoint.";
            var builder = new MicrosoftGraphEndpointRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildMicrosoftGraphServicePrincipalCommand() {
            var command = new Command("microsoft-graph-service-principal");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new MicrosoftGraphServicePrincipalRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        public Command BuildMicrosoftGraphUserCommand() {
            var command = new Command("microsoft-graph-user");
            command.Description = "Casts the previous resource to user.";
            var builder = new MicrosoftGraphUserRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        public Command BuildRefCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of application entities.";
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
            UrlTemplate = "{+baseurl}/applications/{application%2Did}/owners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
