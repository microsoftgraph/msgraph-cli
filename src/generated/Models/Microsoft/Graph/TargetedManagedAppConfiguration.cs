using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TargetedManagedAppConfiguration : ManagedAppConfiguration, IParsable {
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apps", (o,n) => { (o as TargetedManagedAppConfiguration).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>().ToList(); } },
                {"assignments", (o,n) => { (o as TargetedManagedAppConfiguration).Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>().ToList(); } },
                {"deployedAppCount", (o,n) => { (o as TargetedManagedAppConfiguration).DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", (o,n) => { (o as TargetedManagedAppConfiguration).DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(); } },
                {"isAssigned", (o,n) => { (o as TargetedManagedAppConfiguration).IsAssigned = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("isAssigned", IsAssigned);
        }
    }
}
