using Microsoft.Graph.Cli.Authentication;
using Microsoft.Graph.Cli.Utils;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Microsoft.Graph.Cli.Commands.Authentication;

class LoginCommand
{
    private AuthenticationServiceFactory authenticationServiceFactory;

    public LoginCommand(AuthenticationServiceFactory authenticationServiceFactory) {
        this.authenticationServiceFactory = authenticationServiceFactory;
    }

    public Command Build(bool persistToken = false) {
        var loginCommand = new Command("login", "Login and store the session for use in subsequent commands");
        var scopes = new Option<string>("--scopes", "The login scopes e.g. User.Read");
        scopes.IsRequired = true;
        scopes.Arity = ArgumentArity.OneOrMore;
        loginCommand.AddOption(scopes);

        var strategy = new Option<AuthenticationStrategy>("--strategy", () => Constants.defaultAuthStrategy, "The authentication strategy to use.");
        loginCommand.AddOption(strategy);

        loginCommand.Handler = CommandHandler.Create<string[], AuthenticationStrategy>(async (scopes, strategy) =>
        {
            var authService = await this.authenticationServiceFactory.GetAuthenticationServiceAsync(strategy, persistToken);
            await authService.LoginAsync(scopes);
        });

        return loginCommand;
    }
}