using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OnPremisesProvisioningError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.</summary>
        public string Category { get; set; }
        /// <summary>The date and time at which the error occurred.</summary>
        public DateTimeOffset? OccurredDateTime { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress</summary>
        public string PropertyCausingError { get; set; }
        /// <summary>Value of the property causing the error.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new onPremisesProvisioningError and sets the default values.
        /// </summary>
        public OnPremisesProvisioningError() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.onPremisesProvisioningError";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OnPremisesProvisioningError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesProvisioningError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetStringValue(); } },
                {"occurredDateTime", n => { OccurredDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyCausingError", n => { PropertyCausingError = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("category", Category);
            writer.WriteDateTimeOffsetValue("occurredDateTime", OccurredDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("propertyCausingError", PropertyCausingError);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
