using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LicenseUnitsDetail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of units that are enabled for the active subscription of the service SKU.</summary>
        public int? Enabled { get; set; }
        /// <summary>The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.</summary>
        public int? Suspended { get; set; }
        /// <summary>The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).</summary>
        public int? Warning { get; set; }
        /// <summary>
        /// Instantiates a new licenseUnitsDetail and sets the default values.
        /// </summary>
        public LicenseUnitsDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enabled", (o,n) => { (o as LicenseUnitsDetail).Enabled = n.GetIntValue(); } },
                {"suspended", (o,n) => { (o as LicenseUnitsDetail).Suspended = n.GetIntValue(); } },
                {"warning", (o,n) => { (o as LicenseUnitsDetail).Warning = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("enabled", Enabled);
            writer.WriteIntValue("suspended", Suspended);
            writer.WriteIntValue("warning", Warning);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
