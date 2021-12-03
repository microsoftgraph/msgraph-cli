using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LocalizedNotificationMessage : Entity, IParsable {
        /// <summary>Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The Locale for which this message is destined.</summary>
        public string Locale { get; set; }
        /// <summary>The Message Template content.</summary>
        public string MessageTemplate { get; set; }
        /// <summary>The Message Template Subject.</summary>
        public string Subject { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as LocalizedNotificationMessage).IsDefault = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as LocalizedNotificationMessage).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", (o,n) => { (o as LocalizedNotificationMessage).Locale = n.GetStringValue(); } },
                {"messageTemplate", (o,n) => { (o as LocalizedNotificationMessage).MessageTemplate = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as LocalizedNotificationMessage).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteStringValue("messageTemplate", MessageTemplate);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
