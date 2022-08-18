using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of authenticationMethodConfiguration entities.</summary>
    public class ContentType : Entity, IParsable {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This will contain all hub sites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.</summary>
        public List<string> AssociatedHubsUrls { get; set; }
        /// <summary>Parent contentType from which this content type is derived.</summary>
        public ContentType Base { get; set; }
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
        public List<ContentType> BaseTypes { get; set; }
        /// <summary>The collection of columns that are required by this content type.</summary>
        public List<ColumnLink> ColumnLinks { get; set; }
        /// <summary>Column order information in a content type.</summary>
        public List<ColumnDefinition> ColumnPositions { get; set; }
        /// <summary>The collection of column definitions for this contentType.</summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>The descriptive text for the item.</summary>
        public string Description { get; set; }
        /// <summary>Document Set metadata.</summary>
        public ApiSdk.Models.DocumentSet DocumentSet { get; set; }
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
        public DocumentSetContent DocumentTemplate { get; set; }
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
        public string Group { get; set; }
        /// <summary>Indicates whether the content type is hidden in the list&apos;s &apos;New&apos; menu.</summary>
        public bool? Hidden { get; set; }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
        public ItemReference InheritedFrom { get; set; }
        /// <summary>Specifies if a content type is a built-in content type.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>The name of the content type.</summary>
        public string Name { get; set; }
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
        public ContentTypeOrder Order { get; set; }
        /// <summary>The unique identifier of the content type.</summary>
        public string ParentId { get; set; }
        /// <summary>If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.</summary>
        public bool? PropagateChanges { get; set; }
        /// <summary>If true, the content type can&apos;t be modified unless this value is first set to false.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>If true, the content type can&apos;t be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed { get; set; }
        /// <summary>
        /// Instantiates a new contentType and sets the default values.
        /// </summary>
        public ContentType() : base() {
            OdataType = "#microsoft.graph.contentType";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ContentType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedHubsUrls", n => { AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"base", n => { Base = n.GetObjectValue<ContentType>(ContentType.CreateFromDiscriminatorValue); } },
                {"baseTypes", n => { BaseTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"columnLinks", n => { ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>(ColumnLink.CreateFromDiscriminatorValue).ToList(); } },
                {"columnPositions", n => { ColumnPositions = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentSet", n => { DocumentSet = n.GetObjectValue<ApiSdk.Models.DocumentSet>(ApiSdk.Models.DocumentSet.CreateFromDiscriminatorValue); } },
                {"documentTemplate", n => { DocumentTemplate = n.GetObjectValue<DocumentSetContent>(DocumentSetContent.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetStringValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", n => { InheritedFrom = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"order", n => { Order = n.GetObjectValue<ContentTypeOrder>(ContentTypeOrder.CreateFromDiscriminatorValue); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"sealed", n => { Sealed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("associatedHubsUrls", AssociatedHubsUrls);
            writer.WriteObjectValue<ContentType>("base", Base);
            writer.WriteCollectionOfObjectValues<ContentType>("baseTypes", BaseTypes);
            writer.WriteCollectionOfObjectValues<ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columnPositions", ColumnPositions);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<ApiSdk.Models.DocumentSet>("documentSet", DocumentSet);
            writer.WriteObjectValue<DocumentSetContent>("documentTemplate", DocumentTemplate);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("sealed", Sealed);
        }
    }
}
