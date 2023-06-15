using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SynchronizationTemplate : Entity, IParsable {
        /// <summary>The applicationId property</summary>
        public Guid? ApplicationId { get; set; }
        /// <summary>The default property</summary>
        public bool? Default { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The discoverable property</summary>
        public bool? Discoverable { get; set; }
        /// <summary>The factoryTag property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FactoryTag { get; set; }
#nullable restore
#else
        public string FactoryTag { get; set; }
#endif
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationMetadataEntry>? Metadata { get; set; }
#nullable restore
#else
        public List<SynchronizationMetadataEntry> Metadata { get; set; }
#endif
        /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationSchema? Schema { get; set; }
#nullable restore
#else
        public SynchronizationSchema Schema { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SynchronizationTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationId", n => { ApplicationId = n.GetGuidValue(); } },
                {"default", n => { Default = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoverable", n => { Discoverable = n.GetBoolValue(); } },
                {"factoryTag", n => { FactoryTag = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<SynchronizationMetadataEntry>(SynchronizationMetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schema", n => { Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("applicationId", ApplicationId);
            writer.WriteBoolValue("default", Default);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("discoverable", Discoverable);
            writer.WriteStringValue("factoryTag", FactoryTag);
            writer.WriteCollectionOfObjectValues<SynchronizationMetadataEntry>("metadata", Metadata);
            writer.WriteObjectValue<SynchronizationSchema>("schema", Schema);
        }
    }
}
