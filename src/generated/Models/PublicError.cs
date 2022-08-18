using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PublicError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the error code.</summary>
        public string Code { get; set; }
        /// <summary>Details of the error.</summary>
        public List<PublicErrorDetail> Details { get; set; }
        /// <summary>Details of the inner error.</summary>
        public PublicInnerError InnerError { get; set; }
        /// <summary>A non-localized message for the developer.</summary>
        public string Message { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The target of the error.</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new publicError and sets the default values.
        /// </summary>
        public PublicError() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.publicError";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PublicError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfObjectValues<PublicErrorDetail>(PublicErrorDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"innerError", n => { InnerError = n.GetObjectValue<PublicInnerError>(PublicInnerError.CreateFromDiscriminatorValue); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"target", n => { Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<PublicErrorDetail>("details", Details);
            writer.WriteObjectValue<PublicInnerError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
