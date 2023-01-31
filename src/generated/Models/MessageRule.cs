using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MessageRule : Entity, IParsable {
        /// <summary>Actions to be taken on a message when the corresponding conditions are fulfilled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MessageRuleActions? Actions { get; set; }
#nullable restore
#else
        public MessageRuleActions Actions { get; set; }
#endif
        /// <summary>Conditions that when fulfilled, will trigger the corresponding actions for that rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MessageRulePredicates? Conditions { get; set; }
#nullable restore
#else
        public MessageRulePredicates Conditions { get; set; }
#endif
        /// <summary>The display name of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Exception conditions for the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MessageRulePredicates? Exceptions { get; set; }
#nullable restore
#else
        public MessageRulePredicates Exceptions { get; set; }
#endif
        /// <summary>Indicates whether the rule is in an error condition. Read-only.</summary>
        public bool? HasError { get; set; }
        /// <summary>Indicates whether the rule is enabled to be applied to messages.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Indicates if the rule is read-only and cannot be modified or deleted by the rules REST API.</summary>
        public bool? IsReadOnly { get; set; }
        /// <summary>Indicates the order in which the rule is executed, among other rules.</summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new MessageRule CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new MessageRule CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actions", n => { Actions = n.GetObjectValue<MessageRuleActions>(MessageRuleActions.CreateFromDiscriminatorValue); } },
                {"conditions", n => { Conditions = n.GetObjectValue<MessageRulePredicates>(MessageRulePredicates.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"exceptions", n => { Exceptions = n.GetObjectValue<MessageRulePredicates>(MessageRulePredicates.CreateFromDiscriminatorValue); } },
                {"hasError", n => { HasError = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isReadOnly", n => { IsReadOnly = n.GetBoolValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
