using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class StsPolicy : PolicyBase, IParsable {
        public List<DirectoryObject> AppliesTo { get; set; }
        /// <summary>A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.</summary>
        public List<string> Definition { get; set; }
        /// <summary>If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.</summary>
        public bool? IsOrganizationDefault { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as StsPolicy).AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"definition", (o,n) => { (o as StsPolicy).Definition = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isOrganizationDefault", (o,n) => { (o as StsPolicy).IsOrganizationDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteCollectionOfPrimitiveValues<string>("definition", Definition);
            writer.WriteBoolValue("isOrganizationDefault", IsOrganizationDefault);
        }
    }
}
