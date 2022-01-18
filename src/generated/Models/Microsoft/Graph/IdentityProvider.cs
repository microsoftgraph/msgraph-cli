using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityProvider : Entity, IParsable {
        /// <summary>The client ID for the application obtained when registering the application with the identity provider. This is a required field.  Required. Not nullable.</summary>
        public string ClientId { get; set; }
        /// <summary>The client secret for the application obtained when registering the application with the identity provider. This is write-only. A read operation will return ****. This is a required field. Required. Not nullable.</summary>
        public string ClientSecret { get; set; }
        /// <summary>The display name of the identity provider. Not nullable.</summary>
        public string Name { get; set; }
        /// <summary>The identity provider type is a required field. For B2B scenario: Google, Facebook. For B2C scenario: Microsoft, Google, Amazon, LinkedIn, Facebook, GitHub, Twitter, Weibo,QQ, WeChat, OpenIDConnect. Not nullable.</summary>
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientId", (o,n) => { (o as IdentityProvider).ClientId = n.GetStringValue(); } },
                {"clientSecret", (o,n) => { (o as IdentityProvider).ClientSecret = n.GetStringValue(); } },
                {"name", (o,n) => { (o as IdentityProvider).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as IdentityProvider).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
        }
    }
}
