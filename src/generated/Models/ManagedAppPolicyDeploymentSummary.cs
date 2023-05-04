using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ManagedAppPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public int? ConfigurationDeployedUserCount { get; set; }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppPolicyDeploymentSummaryPerApp>? ConfigurationDeploymentSummaryPerApp { get; set; }
#nullable restore
#else
        public List<ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp { get; set; }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Not yet documented</summary>
        public DateTimeOffset? LastRefreshTime { get; set; }
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationDeployedUserCount", n => { ConfigurationDeployedUserCount = n.GetIntValue(); } },
                {"configurationDeploymentSummaryPerApp", n => { ConfigurationDeploymentSummaryPerApp = n.GetCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>(ManagedAppPolicyDeploymentSummaryPerApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastRefreshTime", n => { LastRefreshTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationDeployedUserCount", ConfigurationDeployedUserCount);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>("configurationDeploymentSummaryPerApp", ConfigurationDeploymentSummaryPerApp);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshTime", LastRefreshTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
