using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ODataErrors {
    public class InnerError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Client request Id as sent by the client application.</summary>
        public string ClientRequestId { get; set; }
        /// <summary>Date when the error occured.</summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>Request Id as tracked internally by the service</summary>
        public string RequestId { get; set; }
        /// <summary>
        /// Instantiates a new InnerError and sets the default values.
        /// </summary>
        public InnerError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ODataErrors.InnerError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InnerError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"client-request-id", (o,n) => { (o as InnerError).ClientRequestId = n.GetStringValue(); } },
                {"date", (o,n) => { (o as InnerError).Date = n.GetDateTimeOffsetValue(); } },
                {"request-id", (o,n) => { (o as InnerError).RequestId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client-request-id", ClientRequestId);
            writer.WriteDateTimeOffsetValue("date", Date);
            writer.WriteStringValue("request-id", RequestId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
