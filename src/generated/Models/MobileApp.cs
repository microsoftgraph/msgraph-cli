using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>An abstract class containing the base properties for Intune mobile apps.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidStoreApp" => new AndroidStoreApp(),
                "#microsoft.graph.iosStoreApp" => new IosStoreApp(),
                "#microsoft.graph.iosVppApp" => new IosVppApp(),
                "#microsoft.graph.macOSOfficeSuiteApp" => new MacOSOfficeSuiteApp(),
                "#microsoft.graph.managedApp" => new ManagedApp(),
                "#microsoft.graph.microsoftStoreForBusinessApp" => new MicrosoftStoreForBusinessApp(),
                "#microsoft.graph.mobileLobApp" => new MobileLobApp(),
                "#microsoft.graph.webApp" => new WebApp(),
                _ => new MobileApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<MobileAppAssignment>(MobileAppAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"developer", n => { Developer = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                {"isFeatured", n => { IsFeatured = n.GetBoolValue(); } },
                {"largeIcon", n => { LargeIcon = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"publishingState", n => { PublishingState = n.GetEnumValue<MobileAppPublishingState>(); } },
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
