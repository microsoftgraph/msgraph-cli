using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MessageRuleActions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of categories to be assigned to a message.</summary>
        public List<string> AssignCategories { get; set; }
        /// <summary>The ID of a folder that a message is to be copied to.</summary>
        public string CopyToFolder { get; set; }
        /// <summary>Indicates whether a message should be moved to the Deleted Items folder.</summary>
        public bool? Delete { get; set; }
        /// <summary>The email addresses of the recipients to which a message should be forwarded as an attachment.</summary>
        public List<Recipient> ForwardAsAttachmentTo { get; set; }
        /// <summary>The email addresses of the recipients to which a message should be forwarded.</summary>
        public List<Recipient> ForwardTo { get; set; }
        /// <summary>Indicates whether a message should be marked as read.</summary>
        public bool? MarkAsRead { get; set; }
        /// <summary>Sets the importance of the message, which can be: low, normal, high.</summary>
        public Importance? MarkImportance { get; set; }
        /// <summary>The ID of the folder that a message will be moved to.</summary>
        public string MoveToFolder { get; set; }
        /// <summary>Indicates whether a message should be permanently deleted and not saved to the Deleted Items folder.</summary>
        public bool? PermanentDelete { get; set; }
        /// <summary>The email addresses to which a message should be redirected.</summary>
        public List<Recipient> RedirectTo { get; set; }
        /// <summary>Indicates whether subsequent rules should be evaluated.</summary>
        public bool? StopProcessingRules { get; set; }
        /// <summary>
        /// Instantiates a new messageRuleActions and sets the default values.
        /// </summary>
        public MessageRuleActions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MessageRuleActions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRuleActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignCategories", n => { AssignCategories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copyToFolder", n => { CopyToFolder = n.GetStringValue(); } },
                {"delete", n => { Delete = n.GetBoolValue(); } },
                {"forwardAsAttachmentTo", n => { ForwardAsAttachmentTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"forwardTo", n => { ForwardTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"markAsRead", n => { MarkAsRead = n.GetBoolValue(); } },
                {"markImportance", n => { MarkImportance = n.GetEnumValue<Importance>(); } },
                {"moveToFolder", n => { MoveToFolder = n.GetStringValue(); } },
                {"permanentDelete", n => { PermanentDelete = n.GetBoolValue(); } },
                {"redirectTo", n => { RedirectTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"stopProcessingRules", n => { StopProcessingRules = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignCategories", AssignCategories);
            writer.WriteStringValue("copyToFolder", CopyToFolder);
            writer.WriteBoolValue("delete", Delete);
            writer.WriteCollectionOfObjectValues<Recipient>("forwardAsAttachmentTo", ForwardAsAttachmentTo);
            writer.WriteCollectionOfObjectValues<Recipient>("forwardTo", ForwardTo);
            writer.WriteBoolValue("markAsRead", MarkAsRead);
            writer.WriteEnumValue<Importance>("markImportance", MarkImportance);
            writer.WriteStringValue("moveToFolder", MoveToFolder);
            writer.WriteBoolValue("permanentDelete", PermanentDelete);
            writer.WriteCollectionOfObjectValues<Recipient>("redirectTo", RedirectTo);
            writer.WriteBoolValue("stopProcessingRules", StopProcessingRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
