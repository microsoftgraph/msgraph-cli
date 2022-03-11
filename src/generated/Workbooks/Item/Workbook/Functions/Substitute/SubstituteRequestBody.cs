using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Substitute {
    public class SubstituteRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json InstanceNum { get; set; }
        public Json NewText { get; set; }
        public Json OldText { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new substituteRequestBody and sets the default values.
        /// </summary>
        public SubstituteRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubstituteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubstituteRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"instanceNum", (o,n) => { (o as SubstituteRequestBody).InstanceNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"newText", (o,n) => { (o as SubstituteRequestBody).NewText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"oldText", (o,n) => { (o as SubstituteRequestBody).OldText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"text", (o,n) => { (o as SubstituteRequestBody).Text = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("instanceNum", InstanceNum);
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
