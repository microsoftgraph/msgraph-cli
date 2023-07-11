using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ObjectMapping : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeMapping>? AttributeMappings { get; set; }
#nullable restore
#else
        public List<AttributeMapping> AttributeMappings { get; set; }
#endif
        /// <summary>When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The flowTypes property</summary>
        public ObjectFlowTypes? FlowTypes { get; set; }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ObjectMappingMetadataEntry>? Metadata { get; set; }
#nullable restore
#else
        public List<ObjectMappingMetadataEntry> Metadata { get; set; }
#endif
        /// <summary>Human-friendly name of the object mapping.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Defines a filter to be used when deciding whether a given object should be provisioned. For example, you might want to only provision users that are located in the US.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Filter? Scope { get; set; }
#nullable restore
#else
        public Filter Scope { get; set; }
#endif
        /// <summary>Name of the object in the source directory. Must match the object name from the source directory definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceObjectName { get; set; }
#nullable restore
#else
        public string SourceObjectName { get; set; }
#endif
        /// <summary>Name of the object in target directory. Must match the object name from the target directory definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetObjectName { get; set; }
#nullable restore
#else
        public string TargetObjectName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new objectMapping and sets the default values.
        /// </summary>
        public ObjectMapping() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ObjectMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ObjectMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributeMappings", n => { AttributeMappings = n.GetCollectionOfObjectValues<AttributeMapping>(AttributeMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"flowTypes", n => { FlowTypes = n.GetEnumValue<ObjectFlowTypes>(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<ObjectMappingMetadataEntry>(ObjectMappingMetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<Filter>(Filter.CreateFromDiscriminatorValue); } },
                {"sourceObjectName", n => { SourceObjectName = n.GetStringValue(); } },
                {"targetObjectName", n => { TargetObjectName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttributeMapping>("attributeMappings", AttributeMappings);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<ObjectFlowTypes>("flowTypes", FlowTypes);
            writer.WriteCollectionOfObjectValues<ObjectMappingMetadataEntry>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Filter>("scope", Scope);
            writer.WriteStringValue("sourceObjectName", SourceObjectName);
            writer.WriteStringValue("targetObjectName", TargetObjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
