using ApiSdk.Applications.Item.Owners.Item.GraphAppRoleAssignment;
using ApiSdk.Applications.Item.Owners.Item.GraphEndpoint;
using ApiSdk.Applications.Item.Owners.Item.GraphServicePrincipal;
using ApiSdk.Applications.Item.Owners.Item.GraphUser;
using ApiSdk.Applications.Item.Owners.Item.Ref;
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
namespace ApiSdk.Applications.Item.Owners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\owners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Casts the previous resource to appRoleAssignment.
        /// </summary>
        public Command BuildGraphAppRoleAssignmentNavCommand() {
            var command = new Command("graph-app-role-assignment");
            command.Description = "Casts the previous resource to appRoleAssignment.";
            var builder = new GraphAppRoleAssignmentRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to endpoint.
        /// </summary>
        public Command BuildGraphEndpointNavCommand() {
            var command = new Command("graph-endpoint");
            command.Description = "Casts the previous resource to endpoint.";
            var builder = new GraphEndpointRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildGraphServicePrincipalNavCommand() {
            var command = new Command("graph-service-principal");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new GraphServicePrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        public Command BuildGraphUserNavCommand() {
            var command = new Command("graph-user");
            command.Description = "Casts the previous resource to user.";
            var builder = new GraphUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of application entities.";
            var builder = new RefRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/owners/{directoryObject%2Did}", pathParameters) {
        }
    }
}
