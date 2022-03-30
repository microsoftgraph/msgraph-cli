using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SignIn : Entity, IParsable {
        /// <summary>App name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).</summary>
        public string AppDisplayName { get; set; }
        /// <summary>Unique GUID representing the app ID in the Azure Active Directory. Supports $filter (eq operator only).</summary>
        public string AppId { get; set; }
        /// <summary>A list of conditional access policies that are triggered by the corresponding sign-in activity.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
        /// <summary>Identifies the client used for the sign-in activity. Modern authentication clients include Browser and modern clients. Legacy authentication clients include Exchange ActiveSync, IMAP, MAPI, SMTP, POP, and other clients. Supports $filter (eq operator only).</summary>
        public string ClientAppUsed { get; set; }
        /// <summary>Reports status of an activated conditional access policy. Possible values are: success, failure, notApplied, and unknownFutureValue. Supports $filter (eq operator only).</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
        /// <summary>The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity. Supports $filter (eq operator only).</summary>
        public string CorrelationId { get; set; }
        /// <summary>Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Device information from where the sign-in occurred; includes device ID, operating system, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSytem properties.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceDetail DeviceDetail { get; set; }
        /// <summary>IP address of the client used to sign in. Supports $filter (eq and startsWith operators only).</summary>
        public string IpAddress { get; set; }
        /// <summary>Indicates if a sign-in is interactive or not.</summary>
        public bool? IsInteractive { get; set; }
        /// <summary>Provides the city, state, and country code where the sign-in originated. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.</summary>
        public ApiSdk.Models.Microsoft.Graph.SignInLocation Location { get; set; }
        /// <summary>Name of the resource the user signed into. Supports $filter (eq operator only).</summary>
        public string ResourceDisplayName { get; set; }
        /// <summary>ID of the resource that the user signed into. Supports $filter (eq operator only).</summary>
        public string ResourceId { get; set; }
        /// <summary>Provides the 'reason' behind a specific state of a risky user, sign-in or a risk event. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far.  Supports $filter (eq operator only).Note: Details for this property require an Azure AD Premium P2 license. Other licenses return the value hidden.</summary>
        public ApiSdk.Models.Microsoft.Graph.RiskDetail? RiskDetail { get; set; }
        /// <summary>Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue. Supports $filter (eq operator only).</summary>
        public List<RiskEventType?> RiskEventTypes { get; set; }
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).</summary>
        public List<string> RiskEventTypes_v2 { get; set; }
        /// <summary>Aggregated risk level. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only).  Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated { get; set; }
        /// <summary>Risk level during sign-in. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection.  Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
        /// <summary>Reports status of the risky user, sign-in, or a risk event. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue. Supports $filter (eq operator only).</summary>
        public ApiSdk.Models.Microsoft.Graph.RiskState? RiskState { get; set; }
        /// <summary>Sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.</summary>
        public ApiSdk.Models.Microsoft.Graph.SignInStatus Status { get; set; }
        /// <summary>Display name of the user that initiated the sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserDisplayName { get; set; }
        /// <summary>ID of the user that initiated the sign-in. Supports $filter (eq operator only).</summary>
        public string UserId { get; set; }
        /// <summary>User principal name of the user that initiated the sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.SignIn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignIn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as SignIn).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as SignIn).AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", (o,n) => { (o as SignIn).AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppliedConditionalAccessPolicy>(ApiSdk.Models.Microsoft.Graph.AppliedConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"clientAppUsed", (o,n) => { (o as SignIn).ClientAppUsed = n.GetStringValue(); } },
                {"conditionalAccessStatus", (o,n) => { (o as SignIn).ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", (o,n) => { (o as SignIn).CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as SignIn).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDetail", (o,n) => { (o as SignIn).DeviceDetail = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceDetail>(ApiSdk.Models.Microsoft.Graph.DeviceDetail.CreateFromDiscriminatorValue); } },
                {"ipAddress", (o,n) => { (o as SignIn).IpAddress = n.GetStringValue(); } },
                {"isInteractive", (o,n) => { (o as SignIn).IsInteractive = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as SignIn).Location = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SignInLocation>(ApiSdk.Models.Microsoft.Graph.SignInLocation.CreateFromDiscriminatorValue); } },
                {"resourceDisplayName", (o,n) => { (o as SignIn).ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as SignIn).ResourceId = n.GetStringValue(); } },
                {"riskDetail", (o,n) => { (o as SignIn).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes", (o,n) => { (o as SignIn).RiskEventTypes = n.GetCollectionOfEnumValues<RiskEventType>().ToList(); } },
                {"riskEventTypes_v2", (o,n) => { (o as SignIn).RiskEventTypes_v2 = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskLevelAggregated", (o,n) => { (o as SignIn).RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", (o,n) => { (o as SignIn).RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as SignIn).RiskState = n.GetEnumValue<RiskState>(); } },
                {"status", (o,n) => { (o as SignIn).Status = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SignInStatus>(ApiSdk.Models.Microsoft.Graph.SignInStatus.CreateFromDiscriminatorValue); } },
                {"userDisplayName", (o,n) => { (o as SignIn).UserDisplayName = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as SignIn).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as SignIn).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppliedConditionalAccessPolicy>("appliedConditionalAccessPolicies", AppliedConditionalAccessPolicies);
            writer.WriteStringValue("clientAppUsed", ClientAppUsed);
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceDetail>("deviceDetail", DeviceDetail);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isInteractive", IsInteractive);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SignInLocation>("location", Location);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteCollectionOfEnumValues<RiskEventType>("riskEventTypes", RiskEventTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes_v2", RiskEventTypes_v2);
            writer.WriteEnumValue<RiskLevel>("riskLevelAggregated", RiskLevelAggregated);
            writer.WriteEnumValue<RiskLevel>("riskLevelDuringSignIn", RiskLevelDuringSignIn);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SignInStatus>("status", Status);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
