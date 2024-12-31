// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Alert : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The adversary or activity group that is associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActorDisplayName { get; set; }
#nullable restore
#else
        public string ActorDisplayName { get; set; }
#endif
        /// <summary>A collection of other alert properties, including user-defined properties. Any custom details defined in the alert, and any dynamic content in the alert details, are stored here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.Dictionary? AdditionalDataProperty { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.Dictionary AdditionalDataProperty { get; set; }
#endif
        /// <summary>The ID of the policy that generated the alert, and populated when there is a specific policy that generated the alert, whether configured by a customer or a built-in policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertPolicyId { get; set; }
#nullable restore
#else
        public string AlertPolicyId { get; set; }
#endif
        /// <summary>URL for the Microsoft 365 Defender portal alert page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertWebUrl { get; set; }
#nullable restore
#else
        public string AlertWebUrl { get; set; }
#endif
        /// <summary>Owner of the alert, or null if no owner is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>Specifies whether the alert represents a true threat. Possible values are: unknown, falsePositive, truePositive, informationalExpectedActivity, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.AlertClassification? Classification { get; set; }
        /// <summary>Array of comments created by the Security Operations (SecOps) team during the alert management process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.AlertComment>? Comments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.AlertComment> Comments { get; set; }
#endif
        /// <summary>Time when Microsoft 365 Defender created the alert.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>String value describing each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Detection technology or sensor that identified the notable component or activity. Possible values are: unknown, microsoftDefenderForEndpoint, antivirus, smartScreen, customTi, microsoftDefenderForOffice365, automatedInvestigation, microsoftThreatExperts, customDetection, microsoftDefenderForIdentity, cloudAppSecurity, microsoft365Defender, azureAdIdentityProtection, manual, microsoftDataLossPrevention, appGovernancePolicy, appGovernanceDetection, unknownFutureValue, microsoftDefenderForCloud, microsoftDefenderForIoT, microsoftDefenderForServers, microsoftDefenderForStorage, microsoftDefenderForDNS, microsoftDefenderForDatabases, microsoftDefenderForContainers, microsoftDefenderForNetwork, microsoftDefenderForAppService, microsoftDefenderForKeyVault, microsoftDefenderForResourceManager, microsoftDefenderForApiManagement, microsoftSentinel, nrtAlerts, scheduledAlerts, microsoftDefenderThreatIntelligenceAnalytics, builtInMl. You must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: microsoftDefenderForCloud, microsoftDefenderForIoT, microsoftDefenderForServers, microsoftDefenderForStorage, microsoftDefenderForDNS, microsoftDefenderForDatabases, microsoftDefenderForContainers, microsoftDefenderForNetwork, microsoftDefenderForAppService, microsoftDefenderForKeyVault, microsoftDefenderForResourceManager, microsoftDefenderForApiManagement, microsoftSentinel, nrtAlerts, scheduledAlerts, microsoftDefenderThreatIntelligenceAnalytics, builtInMl.</summary>
        public global::ApiSdk.Models.Security.DetectionSource? DetectionSource { get; set; }
        /// <summary>The ID of the detector that triggered the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectorId { get; set; }
#nullable restore
#else
        public string DetectorId { get; set; }
#endif
        /// <summary>Specifies the result of the investigation, whether the alert represents a true attack and if so, the nature of the attack. Possible values are: unknown, apt, malware, securityPersonnel, securityTesting, unwantedSoftware, other, multiStagedAttack, compromisedAccount, phishing, maliciousUserActivity, notMalicious, notEnoughDataToValidate, confirmedUserActivity, lineOfBusinessApplication, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.AlertDetermination? Determination { get; set; }
        /// <summary>Collection of evidence related to the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.AlertEvidence>? Evidence { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.AlertEvidence> Evidence { get; set; }
#endif
        /// <summary>The earliest activity associated with the alert.</summary>
        public DateTimeOffset? FirstActivityDateTime { get; set; }
        /// <summary>Unique identifier to represent the incident this alert resource is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentId { get; set; }
#nullable restore
#else
        public string IncidentId { get; set; }
#endif
        /// <summary>URL for the incident page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentWebUrl { get; set; }
#nullable restore
#else
        public string IncidentWebUrl { get; set; }
#endif
        /// <summary>The oldest activity associated with the alert.</summary>
        public DateTimeOffset? LastActivityDateTime { get; set; }
        /// <summary>Time when the alert was last updated at Microsoft 365 Defender.</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>The attack techniques, as aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MitreTechniques { get; set; }
#nullable restore
#else
        public List<string> MitreTechniques { get; set; }
#endif
        /// <summary>The name of the product which published this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>The ID of the alert as it appears in the security provider product that generated the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderAlertId { get; set; }
#nullable restore
#else
        public string ProviderAlertId { get; set; }
#endif
        /// <summary>Recommended response and remediation actions to take in the event this alert was generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedActions { get; set; }
#nullable restore
#else
        public string RecommendedActions { get; set; }
#endif
        /// <summary>Time when the alert was resolved.</summary>
        public DateTimeOffset? ResolvedDateTime { get; set; }
        /// <summary>The serviceSource property</summary>
        public global::ApiSdk.Models.Security.ServiceSource? ServiceSource { get; set; }
        /// <summary>The severity property</summary>
        public global::ApiSdk.Models.Security.AlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.Security.AlertStatus? Status { get; set; }
        /// <summary>The system tags associated with the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemTags { get; set; }
#nullable restore
#else
        public List<string> SystemTags { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant the alert was created in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The threat associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatDisplayName { get; set; }
#nullable restore
#else
        public string ThreatDisplayName { get; set; }
#endif
        /// <summary>Threat family associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatFamilyName { get; set; }
#nullable restore
#else
        public string ThreatFamilyName { get; set; }
#endif
        /// <summary>Brief identifying string value describing the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actorDisplayName", n => { ActorDisplayName = n.GetStringValue(); } },
                { "additionalData", n => { AdditionalDataProperty = n.GetObjectValue<global::ApiSdk.Models.Security.Dictionary>(global::ApiSdk.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "alertPolicyId", n => { AlertPolicyId = n.GetStringValue(); } },
                { "alertWebUrl", n => { AlertWebUrl = n.GetStringValue(); } },
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "classification", n => { Classification = n.GetEnumValue<global::ApiSdk.Models.Security.AlertClassification>(); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertComment>(global::ApiSdk.Models.Security.AlertComment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectionSource", n => { DetectionSource = n.GetEnumValue<global::ApiSdk.Models.Security.DetectionSource>(); } },
                { "detectorId", n => { DetectorId = n.GetStringValue(); } },
                { "determination", n => { Determination = n.GetEnumValue<global::ApiSdk.Models.Security.AlertDetermination>(); } },
                { "evidence", n => { Evidence = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertEvidence>(global::ApiSdk.Models.Security.AlertEvidence.CreateFromDiscriminatorValue)?.AsList(); } },
                { "firstActivityDateTime", n => { FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "incidentId", n => { IncidentId = n.GetStringValue(); } },
                { "incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                { "lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "mitreTechniques", n => { MitreTechniques = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
                { "providerAlertId", n => { ProviderAlertId = n.GetStringValue(); } },
                { "recommendedActions", n => { RecommendedActions = n.GetStringValue(); } },
                { "resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                { "serviceSource", n => { ServiceSource = n.GetEnumValue<global::ApiSdk.Models.Security.ServiceSource>(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::ApiSdk.Models.Security.AlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.Security.AlertStatus>(); } },
                { "systemTags", n => { SystemTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "threatDisplayName", n => { ThreatDisplayName = n.GetStringValue(); } },
                { "threatFamilyName", n => { ThreatFamilyName = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actorDisplayName", ActorDisplayName);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.Dictionary>("additionalData", AdditionalDataProperty);
            writer.WriteStringValue("alertPolicyId", AlertPolicyId);
            writer.WriteStringValue("alertWebUrl", AlertWebUrl);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("category", Category);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.DetectionSource>("detectionSource", DetectionSource);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertDetermination>("determination", Determination);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertEvidence>("evidence", Evidence);
            writer.WriteDateTimeOffsetValue("firstActivityDateTime", FirstActivityDateTime);
            writer.WriteStringValue("incidentId", IncidentId);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("mitreTechniques", MitreTechniques);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("providerAlertId", ProviderAlertId);
            writer.WriteStringValue("recommendedActions", RecommendedActions);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.ServiceSource>("serviceSource", ServiceSource);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("systemTags", SystemTags);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatDisplayName", ThreatDisplayName);
            writer.WriteStringValue("threatFamilyName", ThreatFamilyName);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
