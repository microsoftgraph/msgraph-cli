using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Reject {
    /// <summary>Provides operations to call the reject method.</summary>
    public class RejectRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CallbackUri { get; set; }
        public RejectReason? Reason { get; set; }
        /// <summary>
        /// Instantiates a new rejectRequestBody and sets the default values.
        /// </summary>
        public RejectRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Communications.Calls.Item.Reject.RejectRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RejectRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"callbackUri", (o,n) => { (o as RejectRequestBody).CallbackUri = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as RejectRequestBody).Reason = n.GetEnumValue<RejectReason>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteEnumValue<RejectReason>("reason", Reason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
