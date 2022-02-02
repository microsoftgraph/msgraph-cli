using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.IntendedPolicies.Item.TargetedManagedAppProtection.Assign;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.IntendedPolicies.Item.TargetedManagedAppProtection.TargetApps;
using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.IntendedPolicies.Item.TargetedManagedAppProtection {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\managedAppRegistrations\{managedAppRegistration-id}\intendedPolicies\{managedAppPolicy-id}\microsoft.graph.targetedManagedAppProtection</summary>
    public class TargetedManagedAppProtectionRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAssignCommand() {
            var command = new Command("assign");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.IntendedPolicies.Item.TargetedManagedAppProtection.Assign.AssignRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTargetAppsCommand() {
            var command = new Command("target-apps");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.IntendedPolicies.Item.TargetedManagedAppProtection.TargetApps.TargetAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new TargetedManagedAppProtectionRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TargetedManagedAppProtectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/managedAppRegistrations/{managedAppRegistration_id}/intendedPolicies/{managedAppPolicy_id}/microsoft.graph.targetedManagedAppProtection";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new TargetedManagedAppProtectionRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TargetedManagedAppProtectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/managedAppRegistrations/{managedAppRegistration_id}/intendedPolicies/{managedAppPolicy_id}/microsoft.graph.targetedManagedAppProtection";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
