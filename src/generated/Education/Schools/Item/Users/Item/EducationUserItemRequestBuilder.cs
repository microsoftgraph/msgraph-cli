using ApiSdk.Education.Schools.Item.Users.Item.Ref;
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
namespace ApiSdk.Education.Schools.Item.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\schools\{educationSchool-id}\users\{educationUser-id}
    /// </summary>
    public class EducationUserItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of educationRoot entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of educationRoot entities.";
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
        /// Instantiates a new EducationUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationUserItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/schools/{educationSchool%2Did}/users/{educationUser%2Did}", pathParameters) {
        }
    }
}
