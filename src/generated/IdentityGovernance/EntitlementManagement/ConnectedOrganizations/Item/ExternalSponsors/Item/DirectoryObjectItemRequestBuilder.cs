using ApiSdk.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.Ref;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item {
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\connectedOrganizations\{connectedOrganization-id}\externalSponsors\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of identityGovernance entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of identityGovernance entities.";
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
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}/externalSponsors/{directoryObject%2Did}", pathParameters) {
        }
    }
}
