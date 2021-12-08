using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LobbyBypassSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether or not to always let dial-in callers bypass the lobby. Optional.</summary>
        public bool? IsDialInBypassEnabled { get; set; }
        /// <summary>Specifies the type of participants that are automatically admitted into a meeting, bypassing the lobby. Optional.</summary>
        public LobbyBypassScope? Scope { get; set; }
        /// <summary>
        /// Instantiates a new lobbyBypassSettings and sets the default values.
        /// </summary>
        public LobbyBypassSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isDialInBypassEnabled", (o,n) => { (o as LobbyBypassSettings).IsDialInBypassEnabled = n.GetBoolValue(); } },
                {"scope", (o,n) => { (o as LobbyBypassSettings).Scope = n.GetEnumValue<LobbyBypassScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDialInBypassEnabled", IsDialInBypassEnabled);
            writer.WriteEnumValue<LobbyBypassScope>("scope", Scope);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
