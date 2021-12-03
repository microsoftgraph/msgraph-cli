using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PublicError : IParsable {
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
        /// <summary>The target of the error.</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new publicError and sets the default values.
        /// </summary>
        public PublicError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as PublicError).Code = n.GetStringValue(); } },
                {"details", (o,n) => { (o as PublicError).Details = n.GetCollectionOfObjectValues<PublicErrorDetail>().ToList(); } },
                {"innerError", (o,n) => { (o as PublicError).InnerError = n.GetObjectValue<PublicInnerError>(); } },
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
            writer.WriteCollectionOfObjectValues<PublicErrorDetail>("details", Details);
            writer.WriteObjectValue<PublicInnerError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
