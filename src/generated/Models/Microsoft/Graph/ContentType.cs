using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ContentType : Entity, IParsable {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This will contain all hubsites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.</summary>
        public List<string> AssociatedHubsUrls { get; set; }
        /// <summary>Parent contentType from which this content type is derived.</summary>
        public ContentType Base { get; set; }
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
        public List<ContentType> BaseTypes { get; set; }
        /// <summary>The collection of columns that are required by this content type</summary>
        public List<ColumnLink> ColumnLinks { get; set; }
        /// <summary>Column order information in a content type.</summary>
        public List<ColumnDefinition> ColumnPositions { get; set; }
        /// <summary>The collection of column definitions for this contentType.</summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>The descriptive text for the item.</summary>
        public string Description { get; set; }
        /// <summary>Document Set metadata.</summary>
        public DocumentSet DocumentSet { get; set; }
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
        public DocumentSetContent DocumentTemplate { get; set; }
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
        public string Group { get; set; }
        /// <summary>Indicates whether the content type is hidden in the list's 'New' menu.</summary>
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
        /// <summary>If true, the content type cannot be modified unless this value is first set to false.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"associatedHubsUrls", (o,n) => { (o as ContentType).AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"base", (o,n) => { (o as ContentType).Base = n.GetObjectValue<ContentType>(); } },
                {"baseTypes", (o,n) => { (o as ContentType).BaseTypes = n.GetCollectionOfObjectValues<ContentType>().ToList(); } },
                {"columnLinks", (o,n) => { (o as ContentType).ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>().ToList(); } },
                {"columnPositions", (o,n) => { (o as ContentType).ColumnPositions = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"columns", (o,n) => { (o as ContentType).Columns = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"description", (o,n) => { (o as ContentType).Description = n.GetStringValue(); } },
                {"documentSet", (o,n) => { (o as ContentType).DocumentSet = n.GetObjectValue<DocumentSet>(); } },
                {"documentTemplate", (o,n) => { (o as ContentType).DocumentTemplate = n.GetObjectValue<DocumentSetContent>(); } },
                {"group", (o,n) => { (o as ContentType).Group = n.GetStringValue(); } },
                {"hidden", (o,n) => { (o as ContentType).Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", (o,n) => { (o as ContentType).InheritedFrom = n.GetObjectValue<ItemReference>(); } },
                {"isBuiltIn", (o,n) => { (o as ContentType).IsBuiltIn = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as ContentType).Name = n.GetStringValue(); } },
                {"order", (o,n) => { (o as ContentType).Order = n.GetObjectValue<ContentTypeOrder>(); } },
                {"parentId", (o,n) => { (o as ContentType).ParentId = n.GetStringValue(); } },
                {"propagateChanges", (o,n) => { (o as ContentType).PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", (o,n) => { (o as ContentType).ReadOnly = n.GetBoolValue(); } },
                {"sealed", (o,n) => { (o as ContentType).Sealed = n.GetBoolValue(); } },
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
            writer.WriteObjectValue<DocumentSet>("documentSet", DocumentSet);
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
