using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.Hlookup {
    public class HlookupPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The lookupValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupValue { get; set; }
#nullable restore
#else
        public Json LookupValue { get; set; }
#endif
        /// <summary>The rangeLookup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RangeLookup { get; set; }
#nullable restore
#else
        public Json RangeLookup { get; set; }
#endif
        /// <summary>The rowIndexNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RowIndexNum { get; set; }
#nullable restore
#else
        public Json RowIndexNum { get; set; }
#endif
        /// <summary>The tableArray property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? TableArray { get; set; }
#nullable restore
#else
        public Json TableArray { get; set; }
#endif
        /// <summary>
        /// Instantiates a new hlookupPostRequestBody and sets the default values.
        /// </summary>
        public HlookupPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HlookupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HlookupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lookupValue", n => { LookupValue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rangeLookup", n => { RangeLookup = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rowIndexNum", n => { RowIndexNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"tableArray", n => { TableArray = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("rangeLookup", RangeLookup);
            writer.WriteObjectValue<Json>("rowIndexNum", RowIndexNum);
            writer.WriteObjectValue<Json>("tableArray", TableArray);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
