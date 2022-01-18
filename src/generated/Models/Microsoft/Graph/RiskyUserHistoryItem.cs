using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RiskyUserHistoryItem : RiskyUser, IParsable {
        /// <summary>The activity related to user risk level change.</summary>
        public RiskUserActivity Activity { get; set; }
        /// <summary>The id of actor that does the operation.</summary>
        public string InitiatedBy { get; set; }
        /// <summary>The id of the user.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as RiskyUserHistoryItem).Activity = n.GetObjectValue<RiskUserActivity>(); } },
                {"initiatedBy", (o,n) => { (o as RiskyUserHistoryItem).InitiatedBy = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as RiskyUserHistoryItem).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<RiskUserActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
