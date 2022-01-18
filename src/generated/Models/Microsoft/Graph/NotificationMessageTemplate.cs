using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class NotificationMessageTemplate : Entity, IParsable {
        /// <summary>The Message Template Branding Options. Branding is defined in the Intune Admin Console. Possible values are: none, includeCompanyLogo, includeCompanyName, includeContactInformation, includeCompanyPortalLink.</summary>
        public NotificationTemplateBrandingOptions? BrandingOptions { get; set; }
        /// <summary>The default locale to fallback onto when the requested locale is not available.</summary>
        public string DefaultLocale { get; set; }
        /// <summary>Display name for the Notification Message Template.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of localized messages for this Notification Message Template.</summary>
        public List<LocalizedNotificationMessage> LocalizedNotificationMessages { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"brandingOptions", (o,n) => { (o as NotificationMessageTemplate).BrandingOptions = n.GetEnumValue<NotificationTemplateBrandingOptions>(); } },
                {"defaultLocale", (o,n) => { (o as NotificationMessageTemplate).DefaultLocale = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as NotificationMessageTemplate).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as NotificationMessageTemplate).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localizedNotificationMessages", (o,n) => { (o as NotificationMessageTemplate).LocalizedNotificationMessages = n.GetCollectionOfObjectValues<LocalizedNotificationMessage>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<NotificationTemplateBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LocalizedNotificationMessage>("localizedNotificationMessages", LocalizedNotificationMessages);
        }
    }
}
