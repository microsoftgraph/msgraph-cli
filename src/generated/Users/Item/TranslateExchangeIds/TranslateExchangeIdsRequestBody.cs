using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.TranslateExchangeIds {
    public class TranslateExchangeIdsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> InputIds { get; set; }
        public ExchangeIdFormat? SourceIdType { get; set; }
        public ExchangeIdFormat? TargetIdType { get; set; }
        /// <summary>
        /// Instantiates a new translateExchangeIdsRequestBody and sets the default values.
        /// </summary>
        public TranslateExchangeIdsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"inputIds", (o,n) => { (o as TranslateExchangeIdsRequestBody).InputIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sourceIdType", (o,n) => { (o as TranslateExchangeIdsRequestBody).SourceIdType = n.GetEnumValue<ExchangeIdFormat>(); } },
                {"targetIdType", (o,n) => { (o as TranslateExchangeIdsRequestBody).TargetIdType = n.GetEnumValue<ExchangeIdFormat>(); } },
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
