using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuditActivityInitiator : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If the resource initiating the activity is an app, this property indicates all the app related information like appId, Name, servicePrincipalId, Name.</summary>
        public ApiSdk.Models.Microsoft.Graph.AppIdentity App { get; set; }
        /// <summary>If the resource initiating the activity is a user, this property Indicates all the user related information like userId, Name, UserPrinicpalName.</summary>
        public ApiSdk.Models.Microsoft.Graph.UserIdentity User { get; set; }
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
        public static ApiSdk.Models.Microsoft.Graph.AuditActivityInitiator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditActivityInitiator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"app", (o,n) => { (o as AuditActivityInitiator).App = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AppIdentity>(ApiSdk.Models.Microsoft.Graph.AppIdentity.CreateFromDiscriminatorValue); } },
                {"user", (o,n) => { (o as AuditActivityInitiator).User = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.UserIdentity>(ApiSdk.Models.Microsoft.Graph.UserIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AppIdentity>("app", App);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.UserIdentity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
