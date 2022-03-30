using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TargetedManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppPolicyAssignment> Assignments { get; set; }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as TargetedManagedAppProtection).Assignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppPolicyAssignment>(ApiSdk.Models.Microsoft.Graph.TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"isAssigned", (o,n) => { (o as TargetedManagedAppProtection).IsAssigned = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("isAssigned", IsAssigned);
        }
    }
}
