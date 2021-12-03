using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UriClickSecurityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClickAction { get; set; }
        public DateTimeOffset? ClickDateTime { get; set; }
        public string Id { get; set; }
        public string SourceId { get; set; }
        public string UriDomain { get; set; }
        public string Verdict { get; set; }
        /// <summary>
        /// Instantiates a new uriClickSecurityState and sets the default values.
        /// </summary>
        public UriClickSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clickAction", (o,n) => { (o as UriClickSecurityState).ClickAction = n.GetStringValue(); } },
                {"clickDateTime", (o,n) => { (o as UriClickSecurityState).ClickDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", (o,n) => { (o as UriClickSecurityState).Id = n.GetStringValue(); } },
                {"sourceId", (o,n) => { (o as UriClickSecurityState).SourceId = n.GetStringValue(); } },
                {"uriDomain", (o,n) => { (o as UriClickSecurityState).UriDomain = n.GetStringValue(); } },
                {"verdict", (o,n) => { (o as UriClickSecurityState).Verdict = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clickAction", ClickAction);
            writer.WriteDateTimeOffsetValue("clickDateTime", ClickDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteStringValue("uriDomain", UriDomain);
            writer.WriteStringValue("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
