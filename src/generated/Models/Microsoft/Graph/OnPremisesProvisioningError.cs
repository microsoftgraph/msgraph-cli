using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnPremisesProvisioningError : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.</summary>
        public string Category { get; set; }
        /// <summary>The date and time at which the error occurred.</summary>
        public DateTimeOffset? OccurredDateTime { get; set; }
        /// <summary>Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress</summary>
        public string PropertyCausingError { get; set; }
        /// <summary>Value of the property causing the error.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new onPremisesProvisioningError and sets the default values.
        /// </summary>
        public OnPremisesProvisioningError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"category", (o,n) => { (o as OnPremisesProvisioningError).Category = n.GetStringValue(); } },
                {"occurredDateTime", (o,n) => { (o as OnPremisesProvisioningError).OccurredDateTime = n.GetDateTimeOffsetValue(); } },
                {"propertyCausingError", (o,n) => { (o as OnPremisesProvisioningError).PropertyCausingError = n.GetStringValue(); } },
                {"value", (o,n) => { (o as OnPremisesProvisioningError).Value = n.GetStringValue(); } },
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
            writer.WriteStringValue("propertyCausingError", PropertyCausingError);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
