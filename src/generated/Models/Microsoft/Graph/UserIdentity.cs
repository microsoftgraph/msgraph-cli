using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserIdentity : Identity, IParsable {
        /// <summary>Indicates the client IP address used by user performing the activity (audit log only).</summary>
        public string IpAddress { get; set; }
        /// <summary>The userPrincipalName attribute of the user.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ipAddress", (o,n) => { (o as UserIdentity).IpAddress = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserIdentity).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
