using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CopyNotebookModel : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CreatedBy { get; set; }
        public IdentitySet CreatedByIdentity { get; set; }
        public DateTimeOffset? CreatedTime { get; set; }
        public string Id { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsShared { get; set; }
        public string LastModifiedBy { get; set; }
        public IdentitySet LastModifiedByIdentity { get; set; }
        public DateTimeOffset? LastModifiedTime { get; set; }
        public NotebookLinks Links { get; set; }
        public string Name { get; set; }
        public string SectionGroupsUrl { get; set; }
        public string SectionsUrl { get; set; }
        public string Self { get; set; }
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new CopyNotebookModel and sets the default values.
        /// </summary>
        public CopyNotebookModel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"createdBy", (o,n) => { (o as CopyNotebookModel).CreatedBy = n.GetStringValue(); } },
                {"createdByIdentity", (o,n) => { (o as CopyNotebookModel).CreatedByIdentity = n.GetObjectValue<IdentitySet>(); } },
                {"createdTime", (o,n) => { (o as CopyNotebookModel).CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"id", (o,n) => { (o as CopyNotebookModel).Id = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as CopyNotebookModel).IsDefault = n.GetBoolValue(); } },
                {"isShared", (o,n) => { (o as CopyNotebookModel).IsShared = n.GetBoolValue(); } },
                {"lastModifiedBy", (o,n) => { (o as CopyNotebookModel).LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedByIdentity", (o,n) => { (o as CopyNotebookModel).LastModifiedByIdentity = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedTime", (o,n) => { (o as CopyNotebookModel).LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"links", (o,n) => { (o as CopyNotebookModel).Links = n.GetObjectValue<NotebookLinks>(); } },
                {"name", (o,n) => { (o as CopyNotebookModel).Name = n.GetStringValue(); } },
                {"sectionGroupsUrl", (o,n) => { (o as CopyNotebookModel).SectionGroupsUrl = n.GetStringValue(); } },
                {"sectionsUrl", (o,n) => { (o as CopyNotebookModel).SectionsUrl = n.GetStringValue(); } },
                {"self", (o,n) => { (o as CopyNotebookModel).Self = n.GetStringValue(); } },
                {"userRole", (o,n) => { (o as CopyNotebookModel).UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteObjectValue<IdentitySet>("createdByIdentity", CreatedByIdentity);
            writer.WriteDateTimeOffsetValue("createdTime", CreatedTime);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<IdentitySet>("lastModifiedByIdentity", LastModifiedByIdentity);
            writer.WriteDateTimeOffsetValue("lastModifiedTime", LastModifiedTime);
            writer.WriteObjectValue<NotebookLinks>("links", Links);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteStringValue("self", Self);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
