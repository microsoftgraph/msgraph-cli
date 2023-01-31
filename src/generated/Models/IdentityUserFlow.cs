using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IdentityUserFlow : Entity, IParsable {
        public ApiSdk.Models.UserFlowType? UserFlowType { get; set; }
        public float? UserFlowTypeVersion { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new IdentityUserFlow CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new IdentityUserFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.b2xIdentityUserFlow" => new B2xIdentityUserFlow(),
                _ => new IdentityUserFlow(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userFlowType", n => { UserFlowType = n.GetEnumValue<UserFlowType>(); } },
                {"userFlowTypeVersion", n => { UserFlowTypeVersion = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UserFlowType>("userFlowType", UserFlowType);
            writer.WriteFloatValue("userFlowTypeVersion", UserFlowTypeVersion);
        }
    }
}
