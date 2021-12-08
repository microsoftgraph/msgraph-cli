using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MobileApp : Entity, IParsable {
        /// <summary>The list of group assignments for this mobile app.</summary>
        public List<MobileAppAssignment> Assignments { get; set; }
        /// <summary>The list of categories for this app.</summary>
        public List<MobileAppCategory> Categories { get; set; }
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the app.</summary>
        public string Description { get; set; }
        /// <summary>The developer of the app.</summary>
        public string Developer { get; set; }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName { get; set; }
        /// <summary>The more information Url.</summary>
        public string InformationUrl { get; set; }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured { get; set; }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
        public MimeContent LargeIcon { get; set; }
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Notes for the app.</summary>
        public string Notes { get; set; }
        /// <summary>The owner of the app.</summary>
        public string Owner { get; set; }
        /// <summary>The privacy statement Url.</summary>
        public string PrivacyInformationUrl { get; set; }
        /// <summary>The publisher of the app.</summary>
        public string Publisher { get; set; }
        /// <summary>The publishing state for the app. The app cannot be assigned unless the app is published. Possible values are: notPublished, processing, published.</summary>
        public MobileAppPublishingState? PublishingState { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as MobileApp).Assignments = n.GetCollectionOfObjectValues<MobileAppAssignment>().ToList(); } },
                {"categories", (o,n) => { (o as MobileApp).Categories = n.GetCollectionOfObjectValues<MobileAppCategory>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as MobileApp).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as MobileApp).Description = n.GetStringValue(); } },
                {"developer", (o,n) => { (o as MobileApp).Developer = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MobileApp).DisplayName = n.GetStringValue(); } },
                {"informationUrl", (o,n) => { (o as MobileApp).InformationUrl = n.GetStringValue(); } },
                {"isFeatured", (o,n) => { (o as MobileApp).IsFeatured = n.GetBoolValue(); } },
                {"largeIcon", (o,n) => { (o as MobileApp).LargeIcon = n.GetObjectValue<MimeContent>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as MobileApp).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", (o,n) => { (o as MobileApp).Notes = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as MobileApp).Owner = n.GetStringValue(); } },
                {"privacyInformationUrl", (o,n) => { (o as MobileApp).PrivacyInformationUrl = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as MobileApp).Publisher = n.GetStringValue(); } },
                {"publishingState", (o,n) => { (o as MobileApp).PublishingState = n.GetEnumValue<MobileAppPublishingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MobileAppAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("categories", Categories);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("developer", Developer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteBoolValue("isFeatured", IsFeatured);
            writer.WriteObjectValue<MimeContent>("largeIcon", LargeIcon);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteEnumValue<MobileAppPublishingState>("publishingState", PublishingState);
        }
    }
}
