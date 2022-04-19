using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.ODataErrors {
    public class MainError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code property</summary>
        public string Code { get; set; }
        /// <summary>The details property</summary>
        public List<ErrorDetails> Details { get; set; }
        /// <summary>The innererror property</summary>
        public ApiSdk.Models.ODataErrors.InnerError Innererror { get; set; }
        /// <summary>The message property</summary>
        public string Message { get; set; }
        /// <summary>The target property</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new MainError and sets the default values.
        /// </summary>
        public MainError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MainError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MainError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfObjectValues<ErrorDetails>(ErrorDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"innererror", n => { Innererror = n.GetObjectValue<ApiSdk.Models.ODataErrors.InnerError>(ApiSdk.Models.ODataErrors.InnerError.CreateFromDiscriminatorValue); } },
                {"message", n => { Message = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ErrorDetails>("details", Details);
            writer.WriteObjectValue<ApiSdk.Models.ODataErrors.InnerError>("innererror", Innererror);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
