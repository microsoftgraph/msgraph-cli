using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ScheduleItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date, time, and time zone that the corresponding event ends.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone End { get; set; }
        /// <summary>The sensitivity of the corresponding event. True if the event is marked private, false otherwise. Optional.</summary>
        public bool? IsPrivate { get; set; }
        /// <summary>The location where the corresponding event is held or attended from. Optional.</summary>
        public string Location { get; set; }
        /// <summary>The date, time, and time zone that the corresponding event starts.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone Start { get; set; }
        /// <summary>The availability status of the user or resource during the corresponding event. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? Status { get; set; }
        /// <summary>The corresponding event's subject line. Optional.</summary>
        public string Subject { get; set; }
        /// <summary>
        /// Instantiates a new scheduleItem and sets the default values.
        /// </summary>
        public ScheduleItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ScheduleItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"end", (o,n) => { (o as ScheduleItem).End = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"isPrivate", (o,n) => { (o as ScheduleItem).IsPrivate = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as ScheduleItem).Location = n.GetStringValue(); } },
                {"start", (o,n) => { (o as ScheduleItem).Start = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as ScheduleItem).Status = n.GetEnumValue<FreeBusyStatus>(); } },
                {"subject", (o,n) => { (o as ScheduleItem).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("end", End);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteStringValue("location", Location);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("start", Start);
            writer.WriteEnumValue<FreeBusyStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
