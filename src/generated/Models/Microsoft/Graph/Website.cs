using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Website : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URL of the website.</summary>
        public string Address { get; set; }
        /// <summary>The display name of the web site.</summary>
        public string DisplayName { get; set; }
        /// <summary>Possible values are: other, home, work, blog, profile.</summary>
        public WebsiteType? Type { get; set; }
        /// <summary>
        /// Instantiates a new website and sets the default values.
        /// </summary>
        public Website() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as Website).Address = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Website).DisplayName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Website).Type = n.GetEnumValue<WebsiteType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<WebsiteType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
