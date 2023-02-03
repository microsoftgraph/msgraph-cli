using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ConversationThread : Entity, IParsable {
        /// <summary>The Cc: recipients for the thread. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? CcRecipients { get; set; }
#nullable restore
#else
        public List<Recipient> CcRecipients { get; set; }
#endif
        /// <summary>Indicates whether any of the posts within this thread has at least one attachment. Returned by default.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Indicates if the thread is locked. Returned by default.</summary>
        public bool? IsLocked { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.Returned by default.</summary>
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
        /// <summary>The posts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Post>? Posts { get; set; }
#nullable restore
#else
        public List<Post> Posts { get; set; }
#endif
        /// <summary>A short summary from the body of the latest post in this conversation. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Preview { get; set; }
#nullable restore
#else
        public string Preview { get; set; }
#endif
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic { get; set; }
#nullable restore
#else
        public string Topic { get; set; }
#endif
        /// <summary>The To: recipients for the thread. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ToRecipients { get; set; }
#nullable restore
#else
        public List<Recipient> ToRecipients { get; set; }
#endif
        /// <summary>All the users that sent a message to this thread. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UniqueSenders { get; set; }
#nullable restore
#else
        public List<string> UniqueSenders { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConversationThread CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConversationThread();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ccRecipients", n => { CcRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"isLocked", n => { IsLocked = n.GetBoolValue(); } },
                {"lastDeliveredDateTime", n => { LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                {"posts", n => { Posts = n.GetCollectionOfObjectValues<Post>(Post.CreateFromDiscriminatorValue)?.ToList(); } },
                {"preview", n => { Preview = n.GetStringValue(); } },
                {"topic", n => { Topic = n.GetStringValue(); } },
                {"toRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"uniqueSenders", n => { UniqueSenders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isLocked", IsLocked);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteCollectionOfObjectValues<Post>("posts", Posts);
            writer.WriteStringValue("preview", Preview);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
