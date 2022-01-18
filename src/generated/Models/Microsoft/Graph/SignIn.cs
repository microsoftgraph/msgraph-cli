using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SignIn : Entity, IParsable {
        /// <summary>The application name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The application identifier in Azure Active Directory. Supports $filter (eq operator only).</summary>
        public string AppId { get; set; }
        /// <summary>A list of conditional access policies that are triggered by the corresponding sign-in activity.</summary>
        public List<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
        /// <summary>The legacy client used for sign-in activity. For example: Browser, Exchange Active Sync, Modern clients, IMAP, MAPI, SMTP, or POP. Supports $filter (eq operator only).</summary>
        public string ClientAppUsed { get; set; }
        /// <summary>The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
        /// <summary>The identifier that's sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support. Supports $filter (eq operator only).</summary>
        public string CorrelationId { get; set; }
        /// <summary>The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSystem properties.</summary>
        public DeviceDetail DeviceDetail { get; set; }
        /// <summary>The IP address of the client from where the sign-in occurred. Supports $filter (eq and startsWith operators only).</summary>
        public string IpAddress { get; set; }
        /// <summary>Indicates whether a user sign in is interactive. In interactive sign in, the user provides an authentication factor to Azure AD. These factors include passwords, responses to MFA challenges, biometric factors, or QR codes that a user provides to Azure AD or an associated app. In non-interactive sign in, the user doesn't provide an authentication factor. Instead, the client app uses a token or code to authenticate or access a resource on behalf of a user. Non-interactive sign ins are commonly used for a client to sign in on a user's behalf in a process transparent to the user.</summary>
        public bool? IsInteractive { get; set; }
        /// <summary>The city, state, and 2 letter country code from where the sign-in occurred. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.</summary>
        public SignInLocation Location { get; set; }
        /// <summary>The name of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
        public string ResourceDisplayName { get; set; }
        /// <summary>The identifier of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
        public string ResourceId { get; set; }
        /// <summary>The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskDetail? RiskDetail { get; set; }
        /// <summary>Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue. Supports $filter (eq operator only).</summary>
        public List<RiskEventType?> RiskEventTypes { get; set; }
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).</summary>
        public List<string> RiskEventTypes_v2 { get; set; }
        /// <summary>The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated { get; set; }
        /// <summary>The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
        /// <summary>The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public RiskState? RiskState { get; set; }
        /// <summary>The sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.</summary>
        public SignInStatus Status { get; set; }
        /// <summary>The display name of the user. Supports $filter (eq and startsWith operators only).</summary>
        public string UserDisplayName { get; set; }
        /// <summary>The identifier of the user. Supports $filter (eq operator only).</summary>
        public string UserId { get; set; }
        /// <summary>The UPN of the user. Supports $filter (eq and startsWith operators only).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as SignIn).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as SignIn).AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", (o,n) => { (o as SignIn).AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<AppliedConditionalAccessPolicy>().ToList(); } },
                {"clientAppUsed", (o,n) => { (o as SignIn).ClientAppUsed = n.GetStringValue(); } },
                {"conditionalAccessStatus", (o,n) => { (o as SignIn).ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", (o,n) => { (o as SignIn).CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as SignIn).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDetail", (o,n) => { (o as SignIn).DeviceDetail = n.GetObjectValue<DeviceDetail>(); } },
                {"ipAddress", (o,n) => { (o as SignIn).IpAddress = n.GetStringValue(); } },
                {"isInteractive", (o,n) => { (o as SignIn).IsInteractive = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as SignIn).Location = n.GetObjectValue<SignInLocation>(); } },
                {"resourceDisplayName", (o,n) => { (o as SignIn).ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as SignIn).ResourceId = n.GetStringValue(); } },
                {"riskDetail", (o,n) => { (o as SignIn).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes", (o,n) => { (o as SignIn).RiskEventTypes = n.GetCollectionOfEnumValues<RiskEventType>().ToList(); } },
                {"riskEventTypes_v2", (o,n) => { (o as SignIn).RiskEventTypes_v2 = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskLevelAggregated", (o,n) => { (o as SignIn).RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", (o,n) => { (o as SignIn).RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as SignIn).RiskState = n.GetEnumValue<RiskState>(); } },
                {"status", (o,n) => { (o as SignIn).Status = n.GetObjectValue<SignInStatus>(); } },
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
            writer.WriteCollectionOfObjectValues<AppliedConditionalAccessPolicy>("appliedConditionalAccessPolicies", AppliedConditionalAccessPolicies);
            writer.WriteStringValue("clientAppUsed", ClientAppUsed);
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DeviceDetail>("deviceDetail", DeviceDetail);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isInteractive", IsInteractive);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteCollectionOfEnumValues<RiskEventType>("riskEventTypes", RiskEventTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes_v2", RiskEventTypes_v2);
            writer.WriteEnumValue<RiskLevel>("riskLevelAggregated", RiskLevelAggregated);
            writer.WriteEnumValue<RiskLevel>("riskLevelDuringSignIn", RiskLevelDuringSignIn);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteObjectValue<SignInStatus>("status", Status);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
