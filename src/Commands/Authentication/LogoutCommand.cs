using Microsoft.Graph.Cli.Core.Authentication;
using Microsoft.Graph.Cli.Core.Utils;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Microsoft.Graph.Cli.Commands.Authentication;

class LogoutCommand
{
    private readonly LogoutService logoutService;

    public LogoutCommand(LogoutService logoutService) {
        this.logoutService = logoutService;
    }

    public Command Build() {
        var logoutCommand = new Command("logout", "Logout by deleting the stored session used in commands");

        logoutCommand.Handler = CommandHandler.Create(() =>
        {
            this.logoutService.Logout();
        });

        return logoutCommand;
    }
}