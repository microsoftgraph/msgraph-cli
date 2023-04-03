using ApiSdk.Education.Schools.Item.Classes.Item.Ref;
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
namespace ApiSdk.Education.Schools.Item.Classes.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\schools\{educationSchool-id}\classes\{educationClass-id}
    /// </summary>
    public class EducationClassItemRequestBuilder : BaseCliRequestBuilder {
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
        /// Instantiates a new EducationClassItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationClassItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}", pathParameters) {
        }
    }
}
