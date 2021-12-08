using System.CommandLine;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli
{
    class Program {
        static async Task<int> Main(string[] args) {
            var rootCommand = new RootCommand(); // TODO: Replace with root command from generated client
            rootCommand.Description = "Microsoft Graph CLI";
            return await rootCommand.InvokeAsync(args);
        }
    }
}
