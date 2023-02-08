using ApiSdk.Education.Classes.Item.Members.Item.Ref;
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
namespace ApiSdk.Education.Classes.Item.Members.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\classes\{educationClass-id}\members\{educationUser-id}
    /// </summary>
    public class EducationUserItemRequestBuilder {
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
        /// Instantiates a new EducationUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationUserItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/education/classes/{educationClass%2Did}/members/{educationUser%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
