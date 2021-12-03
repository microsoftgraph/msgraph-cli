using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MessageRule : Entity, IParsable {
        /// <summary>Actions to be taken on a message when the corresponding conditions are fulfilled.</summary>
        public MessageRuleActions Actions { get; set; }
        /// <summary>Conditions that when fulfilled, will trigger the corresponding actions for that rule.</summary>
        public MessageRulePredicates Conditions { get; set; }
        /// <summary>The display name of the rule.</summary>
        public string DisplayName { get; set; }
        /// <summary>Exception conditions for the rule.</summary>
        public MessageRulePredicates Exceptions { get; set; }
        /// <summary>Indicates whether the rule is in an error condition. Read-only.</summary>
        public bool? HasError { get; set; }
        /// <summary>Indicates whether the rule is enabled to be applied to messages.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Indicates if the rule is read-only and cannot be modified or deleted by the rules REST API.</summary>
        public bool? IsReadOnly { get; set; }
        /// <summary>Indicates the order in which the rule is executed, among other rules.</summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actions", (o,n) => { (o as MessageRule).Actions = n.GetObjectValue<MessageRuleActions>(); } },
                {"conditions", (o,n) => { (o as MessageRule).Conditions = n.GetObjectValue<MessageRulePredicates>(); } },
                {"displayName", (o,n) => { (o as MessageRule).DisplayName = n.GetStringValue(); } },
                {"exceptions", (o,n) => { (o as MessageRule).Exceptions = n.GetObjectValue<MessageRulePredicates>(); } },
                {"hasError", (o,n) => { (o as MessageRule).HasError = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as MessageRule).IsEnabled = n.GetBoolValue(); } },
                {"isReadOnly", (o,n) => { (o as MessageRule).IsReadOnly = n.GetBoolValue(); } },
                {"sequence", (o,n) => { (o as MessageRule).Sequence = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MessageRuleActions>("actions", Actions);
            writer.WriteObjectValue<MessageRulePredicates>("conditions", Conditions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MessageRulePredicates>("exceptions", Exceptions);
            writer.WriteBoolValue("hasError", HasError);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isReadOnly", IsReadOnly);
            writer.WriteIntValue("sequence", Sequence);
        }
    }
}
