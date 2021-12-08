using System.Threading.Tasks;

namespace Microsoft.Graph.Cli.Authentication;

interface IAuthenticationService {
    Task LoginAsync(string[] scopes);
}