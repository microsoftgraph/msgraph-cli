using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Security {
    public class Security : Entity, IParsable {
        /// <summary>The alerts property</summary>
        public List<ApiSdk.Models.Alert> Alerts { get; set; }
        /// <summary>The cases property</summary>
        public CasesRoot Cases { get; set; }
        /// <summary>The secureScoreControlProfiles property</summary>
        public List<ApiSdk.Models.SecureScoreControlProfile> SecureScoreControlProfiles { get; set; }
        /// <summary>The secureScores property</summary>
        public List<ApiSdk.Models.SecureScore> SecureScores { get; set; }
        /// <summary>
        /// Instantiates a new Security and sets the default values.
        /// </summary>
        public Security() : base() {
            OdataType = "#microsoft.graph.security";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<ApiSdk.Models.Alert>(ApiSdk.Models.Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cases", n => { Cases = n.GetObjectValue<CasesRoot>(CasesRoot.CreateFromDiscriminatorValue); } },
                {"secureScoreControlProfiles", n => { SecureScoreControlProfiles = n.GetCollectionOfObjectValues<ApiSdk.Models.SecureScoreControlProfile>(ApiSdk.Models.SecureScoreControlProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScores", n => { SecureScores = n.GetCollectionOfObjectValues<ApiSdk.Models.SecureScore>(ApiSdk.Models.SecureScore.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Alert>("alerts", Alerts);
            writer.WriteObjectValue<CasesRoot>("cases", Cases);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.SecureScore>("secureScores", SecureScores);
        }
    }
}
