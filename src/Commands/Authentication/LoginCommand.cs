using Microsoft.Graph.Cli.Authentication;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Microsoft.Graph.Cli.Commands.Authentication;

class LoginCommand
{
    private IAuthenticationService authenticationService;

    public LoginCommand(IAuthenticationService authenticationService) {
        this.authenticationService = authenticationService;
    }

    public Command Build() {
        var loginCommand = new Command("login", "Login and store the session for use in subsequent commands");
        var scopes = new Option<string>("--scopes", "The login scopes e.g. User.Read");
        scopes.IsRequired = true;
        scopes.Arity = ArgumentArity.OneOrMore;
        loginCommand.AddOption(scopes);
        loginCommand.Handler = CommandHandler.Create<string[]>(async (scopes) =>
        {
            await this.authenticationService.LoginAsync(scopes);
        });

        return loginCommand;
    }
}