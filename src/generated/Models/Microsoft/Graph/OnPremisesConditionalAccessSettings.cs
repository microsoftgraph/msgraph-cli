using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnPremisesConditionalAccessSettings : Entity, IParsable {
        /// <summary>Indicates if on premises conditional access is enabled for this organization</summary>
        public bool? Enabled { get; set; }
        /// <summary>User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</summary>
        public List<string> ExcludedGroups { get; set; }
        /// <summary>User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</summary>
        public List<string> IncludedGroups { get; set; }
        /// <summary>Override the default access rule when allowing a device to ensure access is granted.</summary>
        public bool? OverrideDefaultRule { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"enabled", (o,n) => { (o as OnPremisesConditionalAccessSettings).Enabled = n.GetBoolValue(); } },
                {"excludedGroups", (o,n) => { (o as OnPremisesConditionalAccessSettings).ExcludedGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includedGroups", (o,n) => { (o as OnPremisesConditionalAccessSettings).IncludedGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"overrideDefaultRule", (o,n) => { (o as OnPremisesConditionalAccessSettings).OverrideDefaultRule = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedGroups", ExcludedGroups);
            writer.WriteCollectionOfPrimitiveValues<string>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("overrideDefaultRule", OverrideDefaultRule);
        }
    }
}
