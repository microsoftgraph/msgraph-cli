using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Security : Entity, IParsable {
        /// <summary>Notifications for suspicious or potential security issues in a customer’s tenant.</summary>
        public List<Alert> Alerts { get; set; }
        public List<SecureScoreControlProfile> SecureScoreControlProfiles { get; set; }
        public List<SecureScore> SecureScores { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"alerts", (o,n) => { (o as Security).Alerts = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue).ToList(); } },
                {"secureScoreControlProfiles", (o,n) => { (o as Security).SecureScoreControlProfiles = n.GetCollectionOfObjectValues<SecureScoreControlProfile>(SecureScoreControlProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"secureScores", (o,n) => { (o as Security).SecureScores = n.GetCollectionOfObjectValues<SecureScore>(SecureScore.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Alert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<SecureScore>("secureScores", SecureScores);
        }
    }
}
