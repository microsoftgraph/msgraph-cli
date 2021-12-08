using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ImplicitGrantSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.</summary>
        public bool? EnableAccessTokenIssuance { get; set; }
        /// <summary>Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.</summary>
        public bool? EnableIdTokenIssuance { get; set; }
        /// <summary>
        /// Instantiates a new implicitGrantSettings and sets the default values.
        /// </summary>
        public ImplicitGrantSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enableAccessTokenIssuance", (o,n) => { (o as ImplicitGrantSettings).EnableAccessTokenIssuance = n.GetBoolValue(); } },
                {"enableIdTokenIssuance", (o,n) => { (o as ImplicitGrantSettings).EnableIdTokenIssuance = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enableAccessTokenIssuance", EnableAccessTokenIssuance);
            writer.WriteBoolValue("enableIdTokenIssuance", EnableIdTokenIssuance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
