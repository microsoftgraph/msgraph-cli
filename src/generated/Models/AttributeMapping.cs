using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AttributeMapping : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The defaultValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue { get; set; }
#nullable restore
#else
        public string DefaultValue { get; set; }
#endif
        /// <summary>The exportMissingReferences property</summary>
        public bool? ExportMissingReferences { get; set; }
        /// <summary>The flowBehavior property</summary>
        public AttributeFlowBehavior? FlowBehavior { get; set; }
        /// <summary>The flowType property</summary>
        public AttributeFlowType? FlowType { get; set; }
        /// <summary>The matchingPriority property</summary>
        public int? MatchingPriority { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttributeMappingSource? Source { get; set; }
#nullable restore
#else
        public AttributeMappingSource Source { get; set; }
#endif
        /// <summary>The targetAttributeName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetAttributeName { get; set; }
#nullable restore
#else
        public string TargetAttributeName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new attributeMapping and sets the default values.
        /// </summary>
        public AttributeMapping() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttributeMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"exportMissingReferences", n => { ExportMissingReferences = n.GetBoolValue(); } },
                {"flowBehavior", n => { FlowBehavior = n.GetEnumValue<AttributeFlowBehavior>(); } },
                {"flowType", n => { FlowType = n.GetEnumValue<AttributeFlowType>(); } },
                {"matchingPriority", n => { MatchingPriority = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"source", n => { Source = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                {"targetAttributeName", n => { TargetAttributeName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("exportMissingReferences", ExportMissingReferences);
            writer.WriteEnumValue<AttributeFlowBehavior>("flowBehavior", FlowBehavior);
            writer.WriteEnumValue<AttributeFlowType>("flowType", FlowType);
            writer.WriteIntValue("matchingPriority", MatchingPriority);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("source", Source);
            writer.WriteStringValue("targetAttributeName", TargetAttributeName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
