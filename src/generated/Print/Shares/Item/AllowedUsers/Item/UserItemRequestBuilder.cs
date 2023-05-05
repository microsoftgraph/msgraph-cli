using ApiSdk.Print.Shares.Item.AllowedUsers.Item.MailboxSettings;
using ApiSdk.Print.Shares.Item.AllowedUsers.Item.Ref;
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
namespace ApiSdk.Print.Shares.Item.AllowedUsers.Item {
    /// <summary>
    /// Builds and executes requests for operations under \print\shares\{printerShare-id}\allowedUsers\{user-id}
    /// </summary>
    public class UserItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// The mailboxSettings property
        /// </summary>
        public Command BuildMailboxSettingsNavCommand() {
            var command = new Command("mailbox-settings");
            command.Description = "The mailboxSettings property";
            var builder = new MailboxSettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of print entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of print entities.";
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
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/shares/{printerShare%2Did}/allowedUsers/{user%2Did}", pathParameters) {
        }
    }
}
