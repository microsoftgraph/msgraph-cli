using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamGuestSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, guests can add and update channels.</summary>
        public bool? AllowCreateUpdateChannels { get; set; }
        /// <summary>If set to true, guests can delete channels.</summary>
        public bool? AllowDeleteChannels { get; set; }
        /// <summary>
        /// Instantiates a new teamGuestSettings and sets the default values.
        /// </summary>
        public TeamGuestSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.TeamGuestSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamGuestSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowCreateUpdateChannels", (o,n) => { (o as TeamGuestSettings).AllowCreateUpdateChannels = n.GetBoolValue(); } },
                {"allowDeleteChannels", (o,n) => { (o as TeamGuestSettings).AllowDeleteChannels = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCreateUpdateChannels", AllowCreateUpdateChannels);
            writer.WriteBoolValue("allowDeleteChannels", AllowDeleteChannels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
