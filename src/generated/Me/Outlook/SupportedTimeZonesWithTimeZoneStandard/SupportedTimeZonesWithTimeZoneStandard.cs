using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Outlook.SupportedTimeZonesWithTimeZoneStandard {
    public class SupportedTimeZonesWithTimeZoneStandard : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An identifier for the time zone.</summary>
        public string Alias { get; set; }
        /// <summary>A display string that represents the time zone.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Instantiates a new supportedTimeZonesWithTimeZoneStandard and sets the default values.
        /// </summary>
        public SupportedTimeZonesWithTimeZoneStandard() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alias", (o,n) => { (o as SupportedTimeZonesWithTimeZoneStandard).Alias = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SupportedTimeZonesWithTimeZoneStandard).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alias", Alias);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
