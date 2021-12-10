using System.Threading.Tasks;

namespace Microsoft.Graph.Cli.Authentication;

interface ILoginService {
    Task LoginAsync(string[] scopes);
}