using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewNotificationRecipientItem : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Determines the recipient of the notification email.</summary>
        public AccessReviewNotificationRecipientScope NotificationRecipientScope { get; set; }
        /// <summary>Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients, which sends review completion notifications to the recipients.</summary>
        public string NotificationTemplateType { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewNotificationRecipientItem and sets the default values.
        /// </summary>
        public AccessReviewNotificationRecipientItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"notificationRecipientScope", (o,n) => { (o as AccessReviewNotificationRecipientItem).NotificationRecipientScope = n.GetObjectValue<AccessReviewNotificationRecipientScope>(); } },
                {"notificationTemplateType", (o,n) => { (o as AccessReviewNotificationRecipientItem).NotificationTemplateType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AccessReviewNotificationRecipientScope>("notificationRecipientScope", NotificationRecipientScope);
            writer.WriteStringValue("notificationTemplateType", NotificationTemplateType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
