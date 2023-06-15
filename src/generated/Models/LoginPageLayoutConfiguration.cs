using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class LoginPageLayoutConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isFooterShown property</summary>
        public bool? IsFooterShown { get; set; }
        /// <summary>The isHeaderShown property</summary>
        public bool? IsHeaderShown { get; set; }
        /// <summary>The layoutTemplateType property</summary>
        public ApiSdk.Models.LayoutTemplateType? LayoutTemplateType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new loginPageLayoutConfiguration and sets the default values.
        /// </summary>
        public LoginPageLayoutConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LoginPageLayoutConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginPageLayoutConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isFooterShown", n => { IsFooterShown = n.GetBoolValue(); } },
                {"isHeaderShown", n => { IsHeaderShown = n.GetBoolValue(); } },
                {"layoutTemplateType", n => { LayoutTemplateType = n.GetEnumValue<LayoutTemplateType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isFooterShown", IsFooterShown);
            writer.WriteBoolValue("isHeaderShown", IsHeaderShown);
            writer.WriteEnumValue<LayoutTemplateType>("layoutTemplateType", LayoutTemplateType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
