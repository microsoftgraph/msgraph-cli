using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisioningErrorInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional details in case of error.</summary>
        public string AdditionalDetails { get; set; }
        /// <summary>Categorizes the error code. Possible values are failure, nonServiceFailure, success, unknownFutureValue</summary>
        public ProvisioningStatusErrorCategory? ErrorCategory { get; set; }
        /// <summary>Unique error code if any occurred. Learn more</summary>
        public string ErrorCode { get; set; }
        /// <summary>Summarizes the status and describes why the status happened.</summary>
        public string Reason { get; set; }
        /// <summary>Provides the resolution for the corresponding error.</summary>
        public string RecommendedAction { get; set; }
        /// <summary>
        /// Instantiates a new provisioningErrorInfo and sets the default values.
        /// </summary>
        public ProvisioningErrorInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalDetails", (o,n) => { (o as ProvisioningErrorInfo).AdditionalDetails = n.GetStringValue(); } },
                {"errorCategory", (o,n) => { (o as ProvisioningErrorInfo).ErrorCategory = n.GetEnumValue<ProvisioningStatusErrorCategory>(); } },
                {"errorCode", (o,n) => { (o as ProvisioningErrorInfo).ErrorCode = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as ProvisioningErrorInfo).Reason = n.GetStringValue(); } },
                {"recommendedAction", (o,n) => { (o as ProvisioningErrorInfo).RecommendedAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteEnumValue<ProvisioningStatusErrorCategory>("errorCategory", ErrorCategory);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
