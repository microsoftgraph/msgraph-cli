using ApiSdk.Print.Shares.Item.AllowedUsers.Item.Ref;
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
namespace ApiSdk.Print.Shares.Item.AllowedUsers.Item {
    /// <summary>
    /// Builds and executes requests for operations under \print\shares\{printerShare-id}\allowedUsers\{user-id}
    /// </summary>
    public class UserItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the collection of print entities.
        /// </summary>
        public Command BuildRefCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of print entities.";
            var builder = new RefRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/print/shares/{printerShare%2Did}/allowedUsers/{user%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
    }
}
