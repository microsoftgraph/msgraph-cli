using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MessageRuleActions : IParsable {
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
        /// <summary>The email address to which a message should be redirected.</summary>
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignCategories", (o,n) => { (o as MessageRuleActions).AssignCategories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copyToFolder", (o,n) => { (o as MessageRuleActions).CopyToFolder = n.GetStringValue(); } },
                {"delete", (o,n) => { (o as MessageRuleActions).Delete = n.GetBoolValue(); } },
                {"forwardAsAttachmentTo", (o,n) => { (o as MessageRuleActions).ForwardAsAttachmentTo = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"forwardTo", (o,n) => { (o as MessageRuleActions).ForwardTo = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"markAsRead", (o,n) => { (o as MessageRuleActions).MarkAsRead = n.GetBoolValue(); } },
                {"markImportance", (o,n) => { (o as MessageRuleActions).MarkImportance = n.GetEnumValue<Importance>(); } },
                {"moveToFolder", (o,n) => { (o as MessageRuleActions).MoveToFolder = n.GetStringValue(); } },
                {"permanentDelete", (o,n) => { (o as MessageRuleActions).PermanentDelete = n.GetBoolValue(); } },
                {"redirectTo", (o,n) => { (o as MessageRuleActions).RedirectTo = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"stopProcessingRules", (o,n) => { (o as MessageRuleActions).StopProcessingRules = n.GetBoolValue(); } },
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
