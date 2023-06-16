using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SynchronizationRule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The containerFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ContainerFilter? ContainerFilter { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ContainerFilter ContainerFilter { get; set; }
#endif
        /// <summary>The editable property</summary>
        public bool? Editable { get; set; }
        /// <summary>The groupFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.GroupFilter? GroupFilter { get; set; }
#nullable restore
#else
        public ApiSdk.Models.GroupFilter GroupFilter { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyStringValuePair>? Metadata { get; set; }
#nullable restore
#else
        public List<StringKeyStringValuePair> Metadata { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The objectMappings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ObjectMapping>? ObjectMappings { get; set; }
#nullable restore
#else
        public List<ObjectMapping> ObjectMappings { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The sourceDirectoryName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceDirectoryName { get; set; }
#nullable restore
#else
        public string SourceDirectoryName { get; set; }
#endif
        /// <summary>The targetDirectoryName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDirectoryName { get; set; }
#nullable restore
#else
        public string TargetDirectoryName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new synchronizationRule and sets the default values.
        /// </summary>
        public SynchronizationRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"containerFilter", n => { ContainerFilter = n.GetObjectValue<ApiSdk.Models.ContainerFilter>(ApiSdk.Models.ContainerFilter.CreateFromDiscriminatorValue); } },
                {"editable", n => { Editable = n.GetBoolValue(); } },
                {"groupFilter", n => { GroupFilter = n.GetObjectValue<ApiSdk.Models.GroupFilter>(ApiSdk.Models.GroupFilter.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"objectMappings", n => { ObjectMappings = n.GetCollectionOfObjectValues<ObjectMapping>(ObjectMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sourceDirectoryName", n => { SourceDirectoryName = n.GetStringValue(); } },
                {"targetDirectoryName", n => { TargetDirectoryName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.ContainerFilter>("containerFilter", ContainerFilter);
            writer.WriteBoolValue("editable", Editable);
            writer.WriteObjectValue<ApiSdk.Models.GroupFilter>("groupFilter", GroupFilter);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectMapping>("objectMappings", ObjectMappings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("sourceDirectoryName", SourceDirectoryName);
            writer.WriteStringValue("targetDirectoryName", TargetDirectoryName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
