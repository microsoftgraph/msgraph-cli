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
    public partial class Incident : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of related alerts. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.Alert>? Alerts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.Alert> Alerts { get; set; }
#endif
        /// <summary>Owner of the incident, or null if no owner is assigned. Free editable text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The specification for the incident. Possible values are: unknown, falsePositive, truePositive, informationalExpectedActivity, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.AlertClassification? Classification { get; set; }
        /// <summary>Array of comments created by the Security Operations (SecOps) team when the incident is managed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.AlertComment>? Comments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.AlertComment> Comments { get; set; }
#endif
        /// <summary>Time when the incident was first created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Array of custom tags associated with an incident.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomTags { get; set; }
#nullable restore
#else
        public List<string> CustomTags { get; set; }
#endif
        /// <summary>Description of the incident.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Specifies the determination of the incident. Possible values are: unknown, apt, malware, securityPersonnel, securityTesting, unwantedSoftware, other, multiStagedAttack, compromisedUser, phishing, maliciousUserActivity, clean, insufficientData, confirmedUserActivity, lineOfBusinessApplication, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.AlertDetermination? Determination { get; set; }
        /// <summary>The incident name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The URL for the incident page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentWebUrl { get; set; }
#nullable restore
#else
        public string IncidentWebUrl { get; set; }
#endif
        /// <summary>The identity that last modified the incident.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy { get; set; }
#nullable restore
#else
        public string LastModifiedBy { get; set; }
#endif
        /// <summary>Time when the incident was last updated.</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>Only populated in case an incident is grouped with another incident, as part of the logic that processes incidents. In such a case, the status property is redirected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectIncidentId { get; set; }
#nullable restore
#else
        public string RedirectIncidentId { get; set; }
#endif
        /// <summary>User input that explains the resolution of the incident and the classification choice. This property contains free editable text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResolvingComment { get; set; }
#nullable restore
#else
        public string ResolvingComment { get; set; }
#endif
        /// <summary>The severity property</summary>
        public global::ApiSdk.Models.Security.AlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.Security.IncidentStatus? Status { get; set; }
        /// <summary>The overview of an attack. When applicable, the summary contains details of what occurred, impacted assets, and the type of attack.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>The system tags associated with the incident.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemTags { get; set; }
#nullable restore
#else
        public List<string> SystemTags { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant in which the alert was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.Incident"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.Incident CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.Incident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alerts", n => { Alerts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.Alert>(global::ApiSdk.Models.Security.Alert.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "classification", n => { Classification = n.GetEnumValue<global::ApiSdk.Models.Security.AlertClassification>(); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertComment>(global::ApiSdk.Models.Security.AlertComment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customTags", n => { CustomTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "determination", n => { Determination = n.GetEnumValue<global::ApiSdk.Models.Security.AlertDetermination>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "redirectIncidentId", n => { RedirectIncidentId = n.GetStringValue(); } },
                { "resolvingComment", n => { ResolvingComment = n.GetStringValue(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::ApiSdk.Models.Security.AlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.Security.IncidentStatus>(); } },
                { "summary", n => { Summary = n.GetStringValue(); } },
                { "systemTags", n => { SystemTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.Alert>("alerts", Alerts);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("customTags", CustomTags);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertDetermination>("determination", Determination);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("redirectIncidentId", RedirectIncidentId);
            writer.WriteStringValue("resolvingComment", ResolvingComment);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.IncidentStatus>("status", Status);
            writer.WriteStringValue("summary", Summary);
            writer.WriteCollectionOfPrimitiveValues<string>("systemTags", SystemTags);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
