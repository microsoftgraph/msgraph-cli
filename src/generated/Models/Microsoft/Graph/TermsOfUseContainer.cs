using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TermsOfUseContainer : Entity, IParsable {
        /// <summary>Represents the current status of a user's response to a company's customizable terms of use agreement.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance> AgreementAcceptances { get; set; }
        /// <summary>Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Agreement> Agreements { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.TermsOfUseContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsOfUseContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agreementAcceptances", (o,n) => { (o as TermsOfUseContainer).AgreementAcceptances = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>(ApiSdk.Models.Microsoft.Graph.AgreementAcceptance.CreateFromDiscriminatorValue).ToList(); } },
                {"agreements", (o,n) => { (o as TermsOfUseContainer).Agreements = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Agreement>(ApiSdk.Models.Microsoft.Graph.Agreement.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Agreement>("agreements", Agreements);
        }
    }
}
