using ApiSdk.IdentityGovernance.EntitlementManagement.Catalogs.Item.AccessPackages.Item.IncompatibleGroups.Item.Ref;
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.Catalogs.Item.AccessPackages.Item.IncompatibleGroups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\catalogs\{accessPackageCatalog-id}\accessPackages\{accessPackage-id}\incompatibleGroups\{group-id}
    /// </summary>
    public class GroupItemRequestBuilder : BaseCliRequestBuilder {
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
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog%2Did}/accessPackages/{accessPackage%2Did}/incompatibleGroups/{group%2Did}", pathParameters) {
        }
    }
}
