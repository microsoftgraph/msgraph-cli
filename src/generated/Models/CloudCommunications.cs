using ApiSdk.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CloudCommunications : Entity, IParsable {
        /// <summary>The callRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallRecord>? CallRecords { get; set; }
#nullable restore
#else
        public List<CallRecord> CallRecords { get; set; }
#endif
        /// <summary>The calls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Call>? Calls { get; set; }
#nullable restore
#else
        public List<Call> Calls { get; set; }
#endif
        /// <summary>The onlineMeetings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnlineMeeting>? OnlineMeetings { get; set; }
#nullable restore
#else
        public List<OnlineMeeting> OnlineMeetings { get; set; }
#endif
        /// <summary>The presences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Presence>? Presences { get; set; }
#nullable restore
#else
        public List<Presence> Presences { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudCommunications CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudCommunications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callRecords", n => { CallRecords = n.GetCollectionOfObjectValues<CallRecord>(CallRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"calls", n => { Calls = n.GetCollectionOfObjectValues<Call>(Call.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onlineMeetings", n => { OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>(OnlineMeeting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"presences", n => { Presences = n.GetCollectionOfObjectValues<Presence>(Presence.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CallRecord>("callRecords", CallRecords);
            writer.WriteCollectionOfObjectValues<Call>("calls", Calls);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteCollectionOfObjectValues<Presence>("presences", Presences);
        }
    }
}
