// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WorkforceIntegration : global::ApiSdk.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion { get; set; }
        /// <summary>Name of the workforce integration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Support to view eligibility-filtered results. Possible values are: none, swapRequest, offerShiftRequest, unknownFutureValue, timeOffReason. You must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: timeOffReason.</summary>
        public global::ApiSdk.Models.EligibilityFilteringEnabledEntities? EligibilityFilteringEnabledEntities { get; set; }
        /// <summary>The workforce integration encryption resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkforceIntegrationEncryption? Encryption { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkforceIntegrationEncryption Encryption { get; set; }
#endif
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts call back to the provided URL when client changes occur to the entities specified in this property. By default, no entities are supported for change notifications. Possible values are: none, shift, swapRequest, userShiftPreferences, openShift, openShiftRequest, offerShiftRequest, unknownFutureValue, timeOffReason, timeOff, timeOffRequest. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: timeOffReason, timeOff, timeOffRequest.</summary>
        public global::ApiSdk.Models.WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WorkforceIntegration"/> and sets the default values.
        /// </summary>
        public WorkforceIntegration() : base()
        {
            OdataType = "#microsoft.graph.workforceIntegration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WorkforceIntegration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WorkforceIntegration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WorkforceIntegration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiVersion", n => { ApiVersion = n.GetIntValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "eligibilityFilteringEnabledEntities", n => { EligibilityFilteringEnabledEntities = n.GetEnumValue<global::ApiSdk.Models.EligibilityFilteringEnabledEntities>(); } },
                { "encryption", n => { Encryption = n.GetObjectValue<global::ApiSdk.Models.WorkforceIntegrationEncryption>(global::ApiSdk.Models.WorkforceIntegrationEncryption.CreateFromDiscriminatorValue); } },
                { "isActive", n => { IsActive = n.GetBoolValue(); } },
                { "supportedEntities", n => { SupportedEntities = n.GetEnumValue<global::ApiSdk.Models.WorkforceIntegrationSupportedEntities>(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteIntValue("apiVersion", ApiVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.EligibilityFilteringEnabledEntities>("eligibilityFilteringEnabledEntities", EligibilityFilteringEnabledEntities);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkforceIntegrationEncryption>("encryption", Encryption);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteEnumValue<global::ApiSdk.Models.WorkforceIntegrationSupportedEntities>("supportedEntities", SupportedEntities);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
