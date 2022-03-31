using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Agreement : Entity, IParsable {
        /// <summary>Read-only. Information about acceptances of this agreement.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance> Acceptances { get; set; }
        /// <summary>Display name of the agreement. The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement. Supports $filter (eq).</summary>
        public string DisplayName { get; set; }
        /// <summary>Default PDF linked to this agreement.</summary>
        public ApiSdk.Models.Microsoft.Graph.AgreementFile File { get; set; }
        /// <summary>PDFs linked to this agreement. This property is in the process of being deprecated. Use the  file property instead. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AgreementFileLocalization> Files { get; set; }
        /// <summary>Indicates whether end users are required to accept this agreement on every device that they access it from. The end user is required to register their device in Azure AD, if they haven't already done so. Supports $filter (eq).</summary>
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
        /// <summary>Indicates whether the user has to expand the agreement before accepting. Supports $filter (eq).</summary>
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
        /// <summary>Expiration schedule and frequency of agreement for all users. Supports $filter (eq).</summary>
        public ApiSdk.Models.Microsoft.Graph.TermsExpiration TermsExpiration { get; set; }
        /// <summary>The duration after which the user must re-accept the terms of use. The value is represented in ISO 8601 format for durations. Supports $filter (eq).</summary>
        public TimeSpan? UserReacceptRequiredFrequency { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Agreement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Agreement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptances", (o,n) => { (o as Agreement).Acceptances = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>(ApiSdk.Models.Microsoft.Graph.AgreementAcceptance.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as Agreement).DisplayName = n.GetStringValue(); } },
                {"file", (o,n) => { (o as Agreement).File = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AgreementFile>(ApiSdk.Models.Microsoft.Graph.AgreementFile.CreateFromDiscriminatorValue); } },
                {"files", (o,n) => { (o as Agreement).Files = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementFileLocalization>(ApiSdk.Models.Microsoft.Graph.AgreementFileLocalization.CreateFromDiscriminatorValue).ToList(); } },
                {"isPerDeviceAcceptanceRequired", (o,n) => { (o as Agreement).IsPerDeviceAcceptanceRequired = n.GetBoolValue(); } },
                {"isViewingBeforeAcceptanceRequired", (o,n) => { (o as Agreement).IsViewingBeforeAcceptanceRequired = n.GetBoolValue(); } },
                {"termsExpiration", (o,n) => { (o as Agreement).TermsExpiration = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermsExpiration>(ApiSdk.Models.Microsoft.Graph.TermsExpiration.CreateFromDiscriminatorValue); } },
                {"userReacceptRequiredFrequency", (o,n) => { (o as Agreement).UserReacceptRequiredFrequency = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>("acceptances", Acceptances);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AgreementFile>("file", File);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementFileLocalization>("files", Files);
            writer.WriteBoolValue("isPerDeviceAcceptanceRequired", IsPerDeviceAcceptanceRequired);
            writer.WriteBoolValue("isViewingBeforeAcceptanceRequired", IsViewingBeforeAcceptanceRequired);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermsExpiration>("termsExpiration", TermsExpiration);
            writer.WriteTimeSpanValue("userReacceptRequiredFrequency", UserReacceptRequiredFrequency);
        }
    }
}
