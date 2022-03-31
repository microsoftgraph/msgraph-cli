using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PublicError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the error code.</summary>
        public string Code { get; set; }
        /// <summary>Details of the error.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail> Details { get; set; }
        /// <summary>Details of the inner error.</summary>
        public ApiSdk.Models.Microsoft.Graph.PublicInnerError InnerError { get; set; }
        /// <summary>A non-localized message for the developer.</summary>
        public string Message { get; set; }
        /// <summary>The target of the error.</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new publicError and sets the default values.
        /// </summary>
        public PublicError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.PublicError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as PublicError).Code = n.GetStringValue(); } },
                {"details", (o,n) => { (o as PublicError).Details = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail>(ApiSdk.Models.Microsoft.Graph.PublicErrorDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"innerError", (o,n) => { (o as PublicError).InnerError = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PublicInnerError>(ApiSdk.Models.Microsoft.Graph.PublicInnerError.CreateFromDiscriminatorValue); } },
                {"message", (o,n) => { (o as PublicError).Message = n.GetStringValue(); } },
                {"target", (o,n) => { (o as PublicError).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail>("details", Details);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PublicInnerError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
