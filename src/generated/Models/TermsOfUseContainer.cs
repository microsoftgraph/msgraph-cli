using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class TermsOfUseContainer : Entity, IParsable {
        /// <summary>Represents the current status of a user&apos;s response to a company&apos;s customizable terms of use agreement.</summary>
        public List<AgreementAcceptance> AgreementAcceptances { get; set; }
        /// <summary>Represents a tenant&apos;s customizable terms of use agreement that&apos;s created and managed with Azure Active Directory (Azure AD).</summary>
        public List<Agreement> Agreements { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TermsOfUseContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsOfUseContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>(AgreementAcceptance.CreateFromDiscriminatorValue).ToList(); } },
                {"agreements", n => { Agreements = n.GetCollectionOfObjectValues<Agreement>(Agreement.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<Agreement>("agreements", Agreements);
        }
    }
}
