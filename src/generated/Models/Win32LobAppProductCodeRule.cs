using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Win32LobAppProductCodeRule : Win32LobAppRule, IParsable {
        /// <summary>The product code of the app.</summary>
        public string ProductCode { get; set; }
        /// <summary>The product version comparison value.</summary>
        public string ProductVersion { get; set; }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppRuleOperator? ProductVersionOperator { get; set; }
        /// <summary>
        /// Instantiates a new Win32LobAppProductCodeRule and sets the default values.
        /// </summary>
        public Win32LobAppProductCodeRule() : base() {
            OdataType = "#microsoft.graph.win32LobAppProductCodeRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppProductCodeRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppProductCodeRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"productVersionOperator", n => { ProductVersionOperator = n.GetEnumValue<Win32LobAppRuleOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteEnumValue<Win32LobAppRuleOperator>("productVersionOperator", ProductVersionOperator);
        }
    }
}
