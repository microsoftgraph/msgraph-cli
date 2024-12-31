// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications;
using Microsoft.Kiota.Abstractions.Extensions;
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
namespace ApiSdk.Identity.AuthenticationEventsFlows.Item.Conditions.Applications
{
    /// <summary>
    /// Builds and executes requests for operations under \identity\authenticationEventsFlows\{authenticationEventsFlow-id}\conditions\applications
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApplicationsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the includeApplications property of the microsoft.graph.authenticationConditionsApplications entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildIncludeApplicationsNavCommand()
        {
            var command = new Command("include-applications");
            command.Description = "Provides operations to manage the includeApplications property of the microsoft.graph.authenticationConditionsApplications entity.";
            var builder = new global::ApiSdk.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.ApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApplicationsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/conditions/applications", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.ApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApplicationsRequestBuilder(string rawUrl) : base("{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/conditions/applications", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
