using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RiskyUser : Entity, IParsable {
        /// <summary>The activity related to user risk level change</summary>
        public List<ApiSdk.Models.Microsoft.Graph.RiskyUserHistoryItem> History { get; set; }
        /// <summary>Indicates whether the user is deleted. Possible values are: true, false.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>Indicates whether a user's risky state is being processed by the backend.</summary>
        public bool? IsProcessing { get; set; }
        /// <summary>Details of the detected risk. Possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.RiskDetail? RiskDetail { get; set; }
        /// <summary>The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RiskLastUpdatedDateTime { get; set; }
        /// <summary>Level of the detected risky user. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.RiskLevel? RiskLevel { get; set; }
        /// <summary>State of the user's risk. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.RiskState? RiskState { get; set; }
        /// <summary>Risky user display name.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Risky user principal name.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.RiskyUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskyUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"history", (o,n) => { (o as RiskyUser).History = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RiskyUserHistoryItem>(ApiSdk.Models.Microsoft.Graph.RiskyUserHistoryItem.CreateFromDiscriminatorValue).ToList(); } },
                {"isDeleted", (o,n) => { (o as RiskyUser).IsDeleted = n.GetBoolValue(); } },
                {"isProcessing", (o,n) => { (o as RiskyUser).IsProcessing = n.GetBoolValue(); } },
                {"riskDetail", (o,n) => { (o as RiskyUser).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskLastUpdatedDateTime", (o,n) => { (o as RiskyUser).RiskLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskLevel", (o,n) => { (o as RiskyUser).RiskLevel = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as RiskyUser).RiskState = n.GetEnumValue<RiskState>(); } },
                {"userDisplayName", (o,n) => { (o as RiskyUser).UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as RiskyUser).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RiskyUserHistoryItem>("history", History);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteBoolValue("isProcessing", IsProcessing);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteDateTimeOffsetValue("riskLastUpdatedDateTime", RiskLastUpdatedDateTime);
            writer.WriteEnumValue<RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
