using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public class BaseItem : Entity, IParsable {
        /// <summary>Identity of the user, device, or application which created the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet CreatedBy { get; set; }
        /// <summary>Identity of the user who created the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.User CreatedByUser { get; set; }
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Provides a user-visible description of the item. Optional.</summary>
        public string Description { get; set; }
        /// <summary>ETag for the item. Read-only.</summary>
        public string ETag { get; set; }
        /// <summary>Identity of the user, device, and application which last modified the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
        /// <summary>Identity of the user who last modified the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.User LastModifiedByUser { get; set; }
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The name of the item. Read-write.</summary>
        public string Name { get; set; }
        /// <summary>Parent information, if the item has a parent. Read-write.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemReference ParentReference { get; set; }
        /// <summary>URL that displays the resource in the browser. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.BaseItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as BaseItem).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdByUser", (o,n) => { (o as BaseItem).CreatedByUser = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.User>(ApiSdk.Models.Microsoft.Graph.User.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as BaseItem).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as BaseItem).Description = n.GetStringValue(); } },
                {"eTag", (o,n) => { (o as BaseItem).ETag = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as BaseItem).LastModifiedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedByUser", (o,n) => { (o as BaseItem).LastModifiedByUser = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.User>(ApiSdk.Models.Microsoft.Graph.User.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as BaseItem).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as BaseItem).Name = n.GetStringValue(); } },
                {"parentReference", (o,n) => { (o as BaseItem).ParentReference = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemReference>(ApiSdk.Models.Microsoft.Graph.ItemReference.CreateFromDiscriminatorValue); } },
                {"webUrl", (o,n) => { (o as BaseItem).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("createdBy", CreatedBy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.User>("createdByUser", CreatedByUser);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.User>("lastModifiedByUser", LastModifiedByUser);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemReference>("parentReference", ParentReference);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
