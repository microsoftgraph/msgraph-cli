using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamMemberSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, members can add and remove apps.</summary>
        public bool? AllowAddRemoveApps { get; set; }
        /// <summary>If set to true, members can add and update private channels.</summary>
        public bool? AllowCreatePrivateChannels { get; set; }
        /// <summary>If set to true, members can add and update any channels.</summary>
        public bool? AllowCreateUpdateChannels { get; set; }
        /// <summary>If set to true, members can add, update, and remove connectors.</summary>
        public bool? AllowCreateUpdateRemoveConnectors { get; set; }
        /// <summary>If set to true, members can add, update, and remove tabs.</summary>
        public bool? AllowCreateUpdateRemoveTabs { get; set; }
        /// <summary>If set to true, members can delete channels.</summary>
        public bool? AllowDeleteChannels { get; set; }
        /// <summary>
        /// Instantiates a new teamMemberSettings and sets the default values.
        /// </summary>
        public TeamMemberSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowAddRemoveApps", (o,n) => { (o as TeamMemberSettings).AllowAddRemoveApps = n.GetBoolValue(); } },
                {"allowCreatePrivateChannels", (o,n) => { (o as TeamMemberSettings).AllowCreatePrivateChannels = n.GetBoolValue(); } },
                {"allowCreateUpdateChannels", (o,n) => { (o as TeamMemberSettings).AllowCreateUpdateChannels = n.GetBoolValue(); } },
                {"allowCreateUpdateRemoveConnectors", (o,n) => { (o as TeamMemberSettings).AllowCreateUpdateRemoveConnectors = n.GetBoolValue(); } },
                {"allowCreateUpdateRemoveTabs", (o,n) => { (o as TeamMemberSettings).AllowCreateUpdateRemoveTabs = n.GetBoolValue(); } },
                {"allowDeleteChannels", (o,n) => { (o as TeamMemberSettings).AllowDeleteChannels = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAddRemoveApps", AllowAddRemoveApps);
            writer.WriteBoolValue("allowCreatePrivateChannels", AllowCreatePrivateChannels);
            writer.WriteBoolValue("allowCreateUpdateChannels", AllowCreateUpdateChannels);
            writer.WriteBoolValue("allowCreateUpdateRemoveConnectors", AllowCreateUpdateRemoveConnectors);
            writer.WriteBoolValue("allowCreateUpdateRemoveTabs", AllowCreateUpdateRemoveTabs);
            writer.WriteBoolValue("allowDeleteChannels", AllowDeleteChannels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
