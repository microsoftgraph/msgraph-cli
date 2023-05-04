using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.Vdb {
    public class VdbPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cost { get; set; }
#nullable restore
#else
        public Json Cost { get; set; }
#endif
        /// <summary>The endPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EndPeriod { get; set; }
#nullable restore
#else
        public Json EndPeriod { get; set; }
#endif
        /// <summary>The factor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Factor { get; set; }
#nullable restore
#else
        public Json Factor { get; set; }
#endif
        /// <summary>The life property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Life { get; set; }
#nullable restore
#else
        public Json Life { get; set; }
#endif
        /// <summary>The noSwitch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NoSwitch { get; set; }
#nullable restore
#else
        public Json NoSwitch { get; set; }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Salvage { get; set; }
#nullable restore
#else
        public Json Salvage { get; set; }
#endif
        /// <summary>The startPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartPeriod { get; set; }
#nullable restore
#else
        public Json StartPeriod { get; set; }
#endif
        /// <summary>
        /// Instantiates a new vdbPostRequestBody and sets the default values.
        /// </summary>
        public VdbPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VdbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VdbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cost", n => { Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"endPeriod", n => { EndPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"factor", n => { Factor = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"life", n => { Life = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"noSwitch", n => { NoSwitch = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", n => { Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startPeriod", n => { StartPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("factor", Factor);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("noSwitch", NoSwitch);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
