using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CopyNotebookModel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdBy property</summary>
        public string CreatedBy { get; set; }
        /// <summary>The createdByIdentity property</summary>
        public IdentitySet CreatedByIdentity { get; set; }
        /// <summary>The createdTime property</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The isShared property</summary>
        public bool? IsShared { get; set; }
        /// <summary>The lastModifiedBy property</summary>
        public string LastModifiedBy { get; set; }
        /// <summary>The lastModifiedByIdentity property</summary>
        public IdentitySet LastModifiedByIdentity { get; set; }
        /// <summary>The lastModifiedTime property</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The links property</summary>
        public NotebookLinks Links { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The sectionGroupsUrl property</summary>
        public string SectionGroupsUrl { get; set; }
        /// <summary>The sectionsUrl property</summary>
        public string SectionsUrl { get; set; }
        /// <summary>The self property</summary>
        public string Self { get; set; }
        /// <summary>The userRole property</summary>
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new CopyNotebookModel and sets the default values.
        /// </summary>
        public CopyNotebookModel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyNotebookModel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyNotebookModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdByIdentity", n => { CreatedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdTime", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedByIdentity", n => { LastModifiedByIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedTime", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"links", n => { Links = n.GetObjectValue<NotebookLinks>(NotebookLinks.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"userRole", n => { UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
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
