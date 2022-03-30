using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FollowupFlag : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time that the follow-up was finished.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone CompletedDateTime { get; set; }
        /// <summary>The date and time that the follow up is to be finished. Note: To set the due date, you must also specify the startDateTime; otherwise, you will get a 400 Bad Request response.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone DueDateTime { get; set; }
        /// <summary>The status for follow-up for an item. Possible values are notFlagged, complete, and flagged.</summary>
        public FollowupFlagStatus? FlagStatus { get; set; }
        /// <summary>The date and time that the follow-up is to begin.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new followupFlag and sets the default values.
        /// </summary>
        public FollowupFlag() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.FollowupFlag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FollowupFlag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"completedDateTime", (o,n) => { (o as FollowupFlag).CompletedDateTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"dueDateTime", (o,n) => { (o as FollowupFlag).DueDateTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"flagStatus", (o,n) => { (o as FollowupFlag).FlagStatus = n.GetEnumValue<FollowupFlagStatus>(); } },
                {"startDateTime", (o,n) => { (o as FollowupFlag).StartDateTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteEnumValue<FollowupFlagStatus>("flagStatus", FlagStatus);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
