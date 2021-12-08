using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamworkActivityTopic : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Type of source. Possible values are: entityUrl, text. For supported Microsoft Graph URLs, use entityUrl. For custom text, use text.</summary>
        public TeamworkActivityTopicSource? Source { get; set; }
        /// <summary>The topic value. If the value of the source property is entityUrl, this must be a Microsoft Graph URL. If the vaule is text, this must be a plain text value.</summary>
        public string Value { get; set; }
        /// <summary>The link the user clicks when they select the notification. Optional when source is entityUrl; required when source is text.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new teamworkActivityTopic and sets the default values.
        /// </summary>
        public TeamworkActivityTopic() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"source", (o,n) => { (o as TeamworkActivityTopic).Source = n.GetEnumValue<TeamworkActivityTopicSource>(); } },
                {"value", (o,n) => { (o as TeamworkActivityTopic).Value = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as TeamworkActivityTopic).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TeamworkActivityTopicSource>("source", Source);
            writer.WriteStringValue("value", Value);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
