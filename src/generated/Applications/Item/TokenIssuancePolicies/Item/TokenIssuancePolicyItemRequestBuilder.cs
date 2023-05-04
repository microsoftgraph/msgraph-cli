using ApiSdk.Applications.Item.TokenIssuancePolicies.Item.Ref;
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
namespace ApiSdk.Applications.Item.TokenIssuancePolicies.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\tokenIssuancePolicies\{tokenIssuancePolicy-id}
    /// </summary>
    public class TokenIssuancePolicyItemRequestBuilder : BaseCliRequestBuilder {
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
        /// Instantiates a new TokenIssuancePolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TokenIssuancePolicyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/tokenIssuancePolicies/{tokenIssuancePolicy%2Did}", pathParameters) {
        }
    }
}
