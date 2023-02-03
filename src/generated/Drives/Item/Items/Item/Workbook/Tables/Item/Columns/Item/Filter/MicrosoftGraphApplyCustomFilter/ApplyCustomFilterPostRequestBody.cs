using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.Filter.MicrosoftGraphApplyCustomFilter {
    public class ApplyCustomFilterPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The criteria1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criteria1 { get; set; }
#nullable restore
#else
        public string Criteria1 { get; set; }
#endif
        /// <summary>The criteria2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criteria2 { get; set; }
#nullable restore
#else
        public string Criteria2 { get; set; }
#endif
        /// <summary>The oper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Oper { get; set; }
#nullable restore
#else
        public string Oper { get; set; }
#endif
        /// <summary>
        /// Instantiates a new applyCustomFilterPostRequestBody and sets the default values.
        /// </summary>
        public ApplyCustomFilterPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplyCustomFilterPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyCustomFilterPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"criteria1", n => { Criteria1 = n.GetStringValue(); } },
                {"criteria2", n => { Criteria2 = n.GetStringValue(); } },
                {"oper", n => { Oper = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("criteria1", Criteria1);
            writer.WriteStringValue("criteria2", Criteria2);
            writer.WriteStringValue("oper", Oper);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
