// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ActivityHistoryItem : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Optional. The duration of active user engagement. if not supplied, this is calculated from the startedDateTime and lastActiveDateTime.</summary>
        public int? ActiveDurationSeconds { get; set; }
        /// <summary>The activity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.UserActivity? Activity { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.UserActivity Activity { get; set; }
#endif
        /// <summary>Set by the server. DateTime in UTC when the object was created on the server.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional. UTC DateTime when the activityHistoryItem will undergo hard-delete. Can be set by the client.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Optional. UTC DateTime when the activityHistoryItem (activity session) was last understood as active or finished - if null, activityHistoryItem status should be Ongoing.</summary>
        public DateTimeOffset? LastActiveDateTime { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object was modified on the server.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Required. UTC DateTime when the activityHistoryItem (activity session) was started. Required for timeline history.</summary>
        public DateTimeOffset? StartedDateTime { get; set; }
        /// <summary>Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.</summary>
        public global::ApiSdk.Models.Status? Status { get; set; }
        /// <summary>Optional. The timezone in which the user&apos;s device used to generate the activity was located at activity creation time. Values supplied as Olson IDs in order to support cross-platform representation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserTimezone { get; set; }
#nullable restore
#else
        public string UserTimezone { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ActivityHistoryItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ActivityHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ActivityHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDurationSeconds", n => { ActiveDurationSeconds = n.GetIntValue(); } },
                { "activity", n => { Activity = n.GetObjectValue<global::ApiSdk.Models.UserActivity>(global::ApiSdk.Models.UserActivity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastActiveDateTime", n => { LastActiveDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.Status>(); } },
                { "userTimezone", n => { UserTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDurationSeconds", ActiveDurationSeconds);
            writer.WriteObjectValue<global::ApiSdk.Models.UserActivity>("activity", Activity);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastActiveDateTime", LastActiveDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
        }
    }
}
#pragma warning restore CS0618
