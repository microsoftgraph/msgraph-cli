using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserActivity : Entity, IParsable {
        /// <summary>Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.</summary>
        public string ActivationUrl { get; set; }
        /// <summary>Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.</summary>
        public string ActivitySourceHost { get; set; }
        /// <summary>Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.</summary>
        public string AppActivityId { get; set; }
        /// <summary>Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>Optional. A custom piece of data - JSON-LD extensible description of content according to schema.org syntax.</summary>
        public Json ContentInfo { get; set; }
        /// <summary>Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).</summary>
        public string ContentUrl { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object was created on the server.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object expired on the server.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Optional. URL used to launch the activity in a web-based app, if available.</summary>
        public string FallbackUrl { get; set; }
        /// <summary>Optional. NavigationProperty/Containment; navigation property to the activity's historyItems.</summary>
        public List<ActivityHistoryItem> HistoryItems { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object was modified on the server.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.</summary>
        public Status? Status { get; set; }
        /// <summary>Optional. The timezone in which the user's device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.</summary>
        public string UserTimezone { get; set; }
        public VisualInfo VisualElements { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activationUrl", (o,n) => { (o as UserActivity).ActivationUrl = n.GetStringValue(); } },
                {"activitySourceHost", (o,n) => { (o as UserActivity).ActivitySourceHost = n.GetStringValue(); } },
                {"appActivityId", (o,n) => { (o as UserActivity).AppActivityId = n.GetStringValue(); } },
                {"appDisplayName", (o,n) => { (o as UserActivity).AppDisplayName = n.GetStringValue(); } },
                {"contentInfo", (o,n) => { (o as UserActivity).ContentInfo = n.GetObjectValue<Json>(); } },
                {"contentUrl", (o,n) => { (o as UserActivity).ContentUrl = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as UserActivity).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", (o,n) => { (o as UserActivity).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackUrl", (o,n) => { (o as UserActivity).FallbackUrl = n.GetStringValue(); } },
                {"historyItems", (o,n) => { (o as UserActivity).HistoryItems = n.GetCollectionOfObjectValues<ActivityHistoryItem>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as UserActivity).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as UserActivity).Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", (o,n) => { (o as UserActivity).UserTimezone = n.GetStringValue(); } },
                {"visualElements", (o,n) => { (o as UserActivity).VisualElements = n.GetObjectValue<VisualInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activationUrl", ActivationUrl);
            writer.WriteStringValue("activitySourceHost", ActivitySourceHost);
            writer.WriteStringValue("appActivityId", AppActivityId);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteObjectValue<Json>("contentInfo", ContentInfo);
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("fallbackUrl", FallbackUrl);
            writer.WriteCollectionOfObjectValues<ActivityHistoryItem>("historyItems", HistoryItems);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
            writer.WriteObjectValue<VisualInfo>("visualElements", VisualElements);
        }
    }
}
