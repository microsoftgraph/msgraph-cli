using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Singleton entity which is used to specify IE mode site metadata
    /// </summary>
    public class BrowserSite : Entity, IParsable {
        /// <summary>Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.</summary>
        public bool? AllowRedirect { get; set; }
        /// <summary>The comment for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The compatibilityMode property</summary>
        public BrowserSiteCompatibilityMode? CompatibilityMode { get; set; }
        /// <summary>The date and time when the site was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time when the site was deleted.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>The history of modifications applied to the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSiteHistory>? History { get; set; }
#nullable restore
#else
        public List<BrowserSiteHistory> History { get; set; }
#endif
        /// <summary>The user who last modified the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time when the site was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The mergeType property</summary>
        public BrowserSiteMergeType? MergeType { get; set; }
        /// <summary>The status property</summary>
        public BrowserSiteStatus? Status { get; set; }
        /// <summary>The targetEnvironment property</summary>
        public BrowserSiteTargetEnvironment? TargetEnvironment { get; set; }
        /// <summary>The URL of the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BrowserSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowRedirect", n => { AllowRedirect = n.GetBoolValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"compatibilityMode", n => { CompatibilityMode = n.GetEnumValue<BrowserSiteCompatibilityMode>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<BrowserSiteHistory>(BrowserSiteHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mergeType", n => { MergeType = n.GetEnumValue<BrowserSiteMergeType>(); } },
                {"status", n => { Status = n.GetEnumValue<BrowserSiteStatus>(); } },
                {"targetEnvironment", n => { TargetEnvironment = n.GetEnumValue<BrowserSiteTargetEnvironment>(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowRedirect", AllowRedirect);
            writer.WriteStringValue("comment", Comment);
            writer.WriteEnumValue<BrowserSiteCompatibilityMode>("compatibilityMode", CompatibilityMode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteCollectionOfObjectValues<BrowserSiteHistory>("history", History);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<BrowserSiteMergeType>("mergeType", MergeType);
            writer.WriteEnumValue<BrowserSiteStatus>("status", Status);
            writer.WriteEnumValue<BrowserSiteTargetEnvironment>("targetEnvironment", TargetEnvironment);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
