using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.TranslateExchangeIds {
    /// <summary>Provides operations to call the translateExchangeIds method.</summary>
    public class TranslateExchangeIdsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The InputIds property</summary>
        public List<string> InputIds { get; set; }
        /// <summary>The SourceIdType property</summary>
        public ExchangeIdFormat? SourceIdType { get; set; }
        /// <summary>The TargetIdType property</summary>
        public ExchangeIdFormat? TargetIdType { get; set; }
        /// <summary>
        /// Instantiates a new translateExchangeIdsRequestBody and sets the default values.
        /// </summary>
        public TranslateExchangeIdsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TranslateExchangeIdsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslateExchangeIdsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"inputIds", n => { InputIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sourceIdType", n => { SourceIdType = n.GetEnumValue<ExchangeIdFormat>(); } },
                {"targetIdType", n => { TargetIdType = n.GetEnumValue<ExchangeIdFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("inputIds", InputIds);
            writer.WriteEnumValue<ExchangeIdFormat>("sourceIdType", SourceIdType);
            writer.WriteEnumValue<ExchangeIdFormat>("targetIdType", TargetIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
