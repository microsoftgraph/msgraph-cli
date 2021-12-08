using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuditActivityInitiator : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If the resource initiating the activity is an app, this property indicates all the app related information like appId, Name, servicePrincipalId, Name.</summary>
        public AppIdentity App { get; set; }
        /// <summary>If the resource initiating the activity is a user, this property Indicates all the user related information like userId, Name, UserPrinicpalName.</summary>
        public UserIdentity User { get; set; }
        /// <summary>
        /// Instantiates a new auditActivityInitiator and sets the default values.
        /// </summary>
        public AuditActivityInitiator() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"app", (o,n) => { (o as AuditActivityInitiator).App = n.GetObjectValue<AppIdentity>(); } },
                {"user", (o,n) => { (o as AuditActivityInitiator).User = n.GetObjectValue<UserIdentity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AppIdentity>("app", App);
            writer.WriteObjectValue<UserIdentity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
