using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class VerifiedDomain : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For example, 'Email', 'OfficeCommunicationsOnline'.</summary>
        public string Capabilities { get; set; }
        /// <summary>true if this is the default domain associated with the tenant; otherwise, false.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>true if this is the initial domain associated with the tenant; otherwise, false</summary>
        public bool? IsInitial { get; set; }
        /// <summary>The domain name; for example, 'contoso.onmicrosoft.com'</summary>
        public string Name { get; set; }
        /// <summary>For example, 'Managed'.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new verifiedDomain and sets the default values.
        /// </summary>
        public VerifiedDomain() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"capabilities", (o,n) => { (o as VerifiedDomain).Capabilities = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as VerifiedDomain).IsDefault = n.GetBoolValue(); } },
                {"isInitial", (o,n) => { (o as VerifiedDomain).IsInitial = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as VerifiedDomain).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as VerifiedDomain).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("capabilities", Capabilities);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isInitial", IsInitial);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
