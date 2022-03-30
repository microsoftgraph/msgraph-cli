using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MailFolder : Entity, IParsable {
        /// <summary>The number of immediate child mailFolders in the current mailFolder.</summary>
        public int? ChildFolderCount { get; set; }
        /// <summary>The collection of child folders in the mailFolder.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MailFolder> ChildFolders { get; set; }
        /// <summary>The mailFolder's display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>The collection of rules that apply to the user's Inbox folder.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MessageRule> MessageRules { get; set; }
        /// <summary>The collection of messages in the mailFolder.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Message> Messages { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The unique identifier for the mailFolder's parent mailFolder.</summary>
        public string ParentFolderId { get; set; }
        /// <summary>The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The number of items in the mailFolder.</summary>
        public int? TotalItemCount { get; set; }
        /// <summary>The number of items in the mailFolder marked as unread.</summary>
        public int? UnreadItemCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.MailFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"childFolderCount", (o,n) => { (o as MailFolder).ChildFolderCount = n.GetIntValue(); } },
                {"childFolders", (o,n) => { (o as MailFolder).ChildFolders = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MailFolder>(ApiSdk.Models.Microsoft.Graph.MailFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as MailFolder).DisplayName = n.GetStringValue(); } },
                {"isHidden", (o,n) => { (o as MailFolder).IsHidden = n.GetBoolValue(); } },
                {"messageRules", (o,n) => { (o as MailFolder).MessageRules = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MessageRule>(ApiSdk.Models.Microsoft.Graph.MessageRule.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", (o,n) => { (o as MailFolder).Messages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Message>(ApiSdk.Models.Microsoft.Graph.Message.CreateFromDiscriminatorValue).ToList(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as MailFolder).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty>(ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"parentFolderId", (o,n) => { (o as MailFolder).ParentFolderId = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as MailFolder).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty>(ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"totalItemCount", (o,n) => { (o as MailFolder).TotalItemCount = n.GetIntValue(); } },
                {"unreadItemCount", (o,n) => { (o as MailFolder).UnreadItemCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("childFolderCount", ChildFolderCount);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MailFolder>("childFolders", ChildFolders);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MessageRule>("messageRules", MessageRules);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteIntValue("totalItemCount", TotalItemCount);
            writer.WriteIntValue("unreadItemCount", UnreadItemCount);
        }
    }
}
