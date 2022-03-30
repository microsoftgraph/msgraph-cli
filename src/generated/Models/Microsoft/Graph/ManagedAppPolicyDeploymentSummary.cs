using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedAppPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public int? ConfigurationDeployedUserCount { get; set; }
        /// <summary>Not yet documented</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp { get; set; }
        /// <summary>Not yet documented</summary>
        public string DisplayName { get; set; }
        /// <summary>Not yet documented</summary>
        public DateTimeOffset? LastRefreshTime { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ManagedAppPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationDeployedUserCount", (o,n) => { (o as ManagedAppPolicyDeploymentSummary).ConfigurationDeployedUserCount = n.GetIntValue(); } },
                {"configurationDeploymentSummaryPerApp", (o,n) => { (o as ManagedAppPolicyDeploymentSummary).ConfigurationDeploymentSummaryPerApp = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicyDeploymentSummaryPerApp>(ApiSdk.Models.Microsoft.Graph.ManagedAppPolicyDeploymentSummaryPerApp.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as ManagedAppPolicyDeploymentSummary).DisplayName = n.GetStringValue(); } },
                {"lastRefreshTime", (o,n) => { (o as ManagedAppPolicyDeploymentSummary).LastRefreshTime = n.GetDateTimeOffsetValue(); } },
                {"version", (o,n) => { (o as ManagedAppPolicyDeploymentSummary).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationDeployedUserCount", ConfigurationDeployedUserCount);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicyDeploymentSummaryPerApp>("configurationDeploymentSummaryPerApp", ConfigurationDeploymentSummaryPerApp);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshTime", LastRefreshTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
