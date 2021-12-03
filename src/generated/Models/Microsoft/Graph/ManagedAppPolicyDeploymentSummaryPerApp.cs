using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedAppPolicyDeploymentSummaryPerApp : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of users the policy is applied.</summary>
        public int? ConfigurationAppliedUserCount { get; set; }
        /// <summary>Deployment of an app.</summary>
        public MobileAppIdentifier MobileAppIdentifier { get; set; }
        /// <summary>
        /// Instantiates a new managedAppPolicyDeploymentSummaryPerApp and sets the default values.
        /// </summary>
        public ManagedAppPolicyDeploymentSummaryPerApp() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configurationAppliedUserCount", (o,n) => { (o as ManagedAppPolicyDeploymentSummaryPerApp).ConfigurationAppliedUserCount = n.GetIntValue(); } },
                {"mobileAppIdentifier", (o,n) => { (o as ManagedAppPolicyDeploymentSummaryPerApp).MobileAppIdentifier = n.GetObjectValue<MobileAppIdentifier>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("configurationAppliedUserCount", ConfigurationAppliedUserCount);
            writer.WriteObjectValue<MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
