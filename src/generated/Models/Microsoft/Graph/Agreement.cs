using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Agreement : Entity, IParsable {
        /// <summary>Read-only. Information about acceptances of this agreement.</summary>
        public List<AgreementAcceptance> Acceptances { get; set; }
        /// <summary>Display name of the agreement. The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement.</summary>
        public string DisplayName { get; set; }
        /// <summary>Default PDF linked to this agreement.</summary>
        public AgreementFile File { get; set; }
        /// <summary>PDFs linked to this agreement. Note: This property is in the process of being deprecated. Use the  file property instead.</summary>
        public List<AgreementFileLocalization> Files { get; set; }
        /// <summary>This setting enables you to require end users to accept this agreement on every device that they are accessing it from. The end user will be required to register their device in Azure AD, if they haven't already done so.</summary>
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
        /// <summary>Indicates whether the user has to expand the agreement before accepting.</summary>
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
        /// <summary>Expiration schedule and frequency of agreement for all users.</summary>
        public TermsExpiration TermsExpiration { get; set; }
        /// <summary>The duration after which the user must re-accept the terms of use. The value is represented in ISO 8601 format for durations.</summary>
        public string UserReacceptRequiredFrequency { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptances", (o,n) => { (o as Agreement).Acceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>().ToList(); } },
                {"displayName", (o,n) => { (o as Agreement).DisplayName = n.GetStringValue(); } },
                {"file", (o,n) => { (o as Agreement).File = n.GetObjectValue<AgreementFile>(); } },
                {"files", (o,n) => { (o as Agreement).Files = n.GetCollectionOfObjectValues<AgreementFileLocalization>().ToList(); } },
                {"isPerDeviceAcceptanceRequired", (o,n) => { (o as Agreement).IsPerDeviceAcceptanceRequired = n.GetBoolValue(); } },
                {"isViewingBeforeAcceptanceRequired", (o,n) => { (o as Agreement).IsViewingBeforeAcceptanceRequired = n.GetBoolValue(); } },
                {"termsExpiration", (o,n) => { (o as Agreement).TermsExpiration = n.GetObjectValue<TermsExpiration>(); } },
                {"userReacceptRequiredFrequency", (o,n) => { (o as Agreement).UserReacceptRequiredFrequency = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("acceptances", Acceptances);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<AgreementFile>("file", File);
            writer.WriteCollectionOfObjectValues<AgreementFileLocalization>("files", Files);
            writer.WriteBoolValue("isPerDeviceAcceptanceRequired", IsPerDeviceAcceptanceRequired);
            writer.WriteBoolValue("isViewingBeforeAcceptanceRequired", IsViewingBeforeAcceptanceRequired);
            writer.WriteObjectValue<TermsExpiration>("termsExpiration", TermsExpiration);
            writer.WriteStringValue("userReacceptRequiredFrequency", UserReacceptRequiredFrequency);
        }
    }
}
