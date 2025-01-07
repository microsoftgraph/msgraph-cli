// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IdentityGovernance : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessReviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AccessReviewSet? AccessReviews { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AccessReviewSet AccessReviews { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appConsent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AppConsentApprovalRoute? AppConsent { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AppConsentApprovalRoute AppConsent { get; set; }
#endif
        /// <summary>The entitlementManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EntitlementManagement? EntitlementManagement { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EntitlementManagement EntitlementManagement { get; set; }
#endif
        /// <summary>The lifecycleWorkflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentityGovernance.LifecycleWorkflowsContainer? LifecycleWorkflows { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentityGovernance.LifecycleWorkflowsContainer LifecycleWorkflows { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The privilegedAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrivilegedAccessRoot? PrivilegedAccess { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrivilegedAccessRoot PrivilegedAccess { get; set; }
#endif
        /// <summary>The termsOfUse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermsOfUseContainer? TermsOfUse { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermsOfUseContainer TermsOfUse { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IdentityGovernance.IdentityGovernance"/> and sets the default values.
        /// </summary>
        public IdentityGovernance()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.IdentityGovernance.IdentityGovernance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IdentityGovernance.IdentityGovernance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessReviews", n => { AccessReviews = n.GetObjectValue<global::ApiSdk.Models.AccessReviewSet>(global::ApiSdk.Models.AccessReviewSet.CreateFromDiscriminatorValue); } },
                { "appConsent", n => { AppConsent = n.GetObjectValue<global::ApiSdk.Models.AppConsentApprovalRoute>(global::ApiSdk.Models.AppConsentApprovalRoute.CreateFromDiscriminatorValue); } },
                { "entitlementManagement", n => { EntitlementManagement = n.GetObjectValue<global::ApiSdk.Models.EntitlementManagement>(global::ApiSdk.Models.EntitlementManagement.CreateFromDiscriminatorValue); } },
                { "lifecycleWorkflows", n => { LifecycleWorkflows = n.GetObjectValue<global::ApiSdk.Models.IdentityGovernance.LifecycleWorkflowsContainer>(global::ApiSdk.Models.IdentityGovernance.LifecycleWorkflowsContainer.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privilegedAccess", n => { PrivilegedAccess = n.GetObjectValue<global::ApiSdk.Models.PrivilegedAccessRoot>(global::ApiSdk.Models.PrivilegedAccessRoot.CreateFromDiscriminatorValue); } },
                { "termsOfUse", n => { TermsOfUse = n.GetObjectValue<global::ApiSdk.Models.TermsOfUseContainer>(global::ApiSdk.Models.TermsOfUseContainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.AccessReviewSet>("accessReviews", AccessReviews);
            writer.WriteObjectValue<global::ApiSdk.Models.AppConsentApprovalRoute>("appConsent", AppConsent);
            writer.WriteObjectValue<global::ApiSdk.Models.EntitlementManagement>("entitlementManagement", EntitlementManagement);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentityGovernance.LifecycleWorkflowsContainer>("lifecycleWorkflows", LifecycleWorkflows);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.PrivilegedAccessRoot>("privilegedAccess", PrivilegedAccess);
            writer.WriteObjectValue<global::ApiSdk.Models.TermsOfUseContainer>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
