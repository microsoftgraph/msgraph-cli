using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class ActivityHistoryItem : Entity, IParsable {
        /// <summary>Optional. The duration of active user engagement. if not supplied, this is calculated from the startedDateTime and lastActiveDateTime.</summary>
        public int? ActiveDurationSeconds { get; set; }
        /// <summary>The activity property</summary>
        public UserActivity Activity { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object was created on the server.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional. UTC DateTime when the historyItem will undergo hard-delete. Can be set by the client.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Optional. UTC DateTime when the historyItem (activity session) was last understood as active or finished - if null, historyItem status should be Ongoing.</summary>
        public DateTimeOffset? LastActiveDateTime { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object was modified on the server.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Required. UTC DateTime when the historyItem (activity session) was started. Required for timeline history.</summary>
        public DateTimeOffset? StartedDateTime { get; set; }
        /// <summary>Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.</summary>
        public ApiSdk.Models.Status? Status { get; set; }
        /// <summary>Optional. The timezone in which the user&apos;s device used to generate the activity was located at activity creation time. Values supplied as Olson IDs in order to support cross-platform representation.</summary>
        public string UserTimezone { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActivityHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivityHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDurationSeconds", n => { ActiveDurationSeconds = n.GetIntValue(); } },
                {"activity", n => { Activity = n.GetObjectValue<UserActivity>(UserActivity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActiveDateTime", n => { LastActiveDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", n => { UserTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDurationSeconds", ActiveDurationSeconds);
            writer.WriteObjectValue<UserActivity>("activity", Activity);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastActiveDateTime", LastActiveDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteEnumValue<Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
        }
    }
}
