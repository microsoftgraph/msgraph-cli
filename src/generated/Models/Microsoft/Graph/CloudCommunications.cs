using ApiSdk.Models.Microsoft.Graph.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public class CloudCommunications : Entity, IParsable {
        public List<CallRecord> CallRecords { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.Call> Calls { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OnlineMeeting> OnlineMeetings { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.Presence> Presences { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.CloudCommunications CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudCommunications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"callRecords", (o,n) => { (o as CloudCommunications).CallRecords = n.GetCollectionOfObjectValues<CallRecord>(CallRecord.CreateFromDiscriminatorValue).ToList(); } },
                {"calls", (o,n) => { (o as CloudCommunications).Calls = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Call>(ApiSdk.Models.Microsoft.Graph.Call.CreateFromDiscriminatorValue).ToList(); } },
                {"onlineMeetings", (o,n) => { (o as CloudCommunications).OnlineMeetings = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnlineMeeting>(ApiSdk.Models.Microsoft.Graph.OnlineMeeting.CreateFromDiscriminatorValue).ToList(); } },
                {"presences", (o,n) => { (o as CloudCommunications).Presences = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Presence>(ApiSdk.Models.Microsoft.Graph.Presence.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CallRecord>("callRecords", CallRecords);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Call>("calls", Calls);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Presence>("presences", Presences);
        }
    }
}
