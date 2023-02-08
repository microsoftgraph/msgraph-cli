using ApiSdk.Education.Users.Item.Assignments.Item.Categories.Item.Ref;
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
namespace ApiSdk.Education.Users.Item.Assignments.Item.Categories.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\users\{educationUser-id}\assignments\{educationAssignment-id}\categories\{educationCategory-id}
    /// </summary>
    public class EducationCategoryItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the collection of educationRoot entities.
        /// </summary>
        public Command BuildRefCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of educationRoot entities.";
            var builder = new RefRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new EducationCategoryItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationCategoryItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/education/users/{educationUser%2Did}/assignments/{educationAssignment%2Did}/categories/{educationCategory%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
