using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AuditActivityInitiator : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If the actor initiating the activity is an app, this property indicates all its identification information including appId, displayName, servicePrincipalId, and servicePrincipalName.</summary>
        public AppIdentity App { get; set; }
        /// <summary>If the actor initiating the activity is a user, this property indicates their identification information including their id, displayName, and userPrincipalName.</summary>
        public UserIdentity User { get; set; }
        /// <summary>
        /// Instantiates a new auditActivityInitiator and sets the default values.
        /// </summary>
        public AuditActivityInitiator() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuditActivityInitiator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditActivityInitiator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"app", n => { App = n.GetObjectValue<AppIdentity>(AppIdentity.CreateFromDiscriminatorValue); } },
                {"user", n => { User = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
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
