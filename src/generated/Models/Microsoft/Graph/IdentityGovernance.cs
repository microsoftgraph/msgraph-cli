using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityGovernance : IAdditionalDataHolder, IParsable {
        public ApiSdk.Models.Microsoft.Graph.AccessReviewSet AccessReviews { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AppConsentApprovalRoute AppConsent { get; set; }
        public ApiSdk.Models.Microsoft.Graph.EntitlementManagement EntitlementManagement { get; set; }
        public ApiSdk.Models.Microsoft.Graph.TermsOfUseContainer TermsOfUse { get; set; }
        /// <summary>
        /// Instantiates a new IdentityGovernance and sets the default values.
        /// </summary>
        public IdentityGovernance() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.IdentityGovernance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityGovernance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessReviews", (o,n) => { (o as IdentityGovernance).AccessReviews = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessReviewSet>(ApiSdk.Models.Microsoft.Graph.AccessReviewSet.CreateFromDiscriminatorValue); } },
                {"appConsent", (o,n) => { (o as IdentityGovernance).AppConsent = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AppConsentApprovalRoute>(ApiSdk.Models.Microsoft.Graph.AppConsentApprovalRoute.CreateFromDiscriminatorValue); } },
                {"entitlementManagement", (o,n) => { (o as IdentityGovernance).EntitlementManagement = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagement>(ApiSdk.Models.Microsoft.Graph.EntitlementManagement.CreateFromDiscriminatorValue); } },
                {"termsOfUse", (o,n) => { (o as IdentityGovernance).TermsOfUse = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermsOfUseContainer>(ApiSdk.Models.Microsoft.Graph.TermsOfUseContainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessReviewSet>("accessReviews", AccessReviews);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AppConsentApprovalRoute>("appConsent", AppConsent);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagement>("entitlementManagement", EntitlementManagement);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermsOfUseContainer>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
