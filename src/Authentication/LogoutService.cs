using System.IO;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

public class LogoutService {
    public void Logout() {
        if (File.Exists(Constants.AuthRecordPath)) {
            File.Delete(Constants.AuthRecordPath);
        }
    }
}