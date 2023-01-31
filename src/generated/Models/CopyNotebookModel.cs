using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CopyNotebookModel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedByIdentity { get; set; }
#nullable restore
#else
        public IdentitySet CreatedByIdentity { get; set; }
#endif
        public DateTimeOffset? CreatedTime { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        public bool? IsDefault { get; set; }
        public bool? IsShared { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy { get; set; }
#nullable restore
#else
        public string LastModifiedBy { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedByIdentity { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedByIdentity { get; set; }
#endif
        public DateTimeOffset? LastModifiedTime { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NotebookLinks? Links { get; set; }
#nullable restore
#else
        public NotebookLinks Links { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionGroupsUrl { get; set; }
#nullable restore
#else
        public string SectionGroupsUrl { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionsUrl { get; set; }
#nullable restore
#else
        public string SectionsUrl { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; set; }
#nullable restore
#else
        public string Self { get; set; }
#endif
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new CopyNotebookModel and sets the default values.
        /// </summary>
        public CopyNotebookModel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static CopyNotebookModel CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static CopyNotebookModel CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"userRole", n => { UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteStringValue("self", Self);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
