using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TermsOfUseContainer : Entity, IParsable {
        /// <summary>Represents the current status of a user's response to a company's customizable terms of use agreement.</summary>
        public List<AgreementAcceptance> AgreementAcceptances { get; set; }
        /// <summary>Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).</summary>
        public List<Agreement> Agreements { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agreementAcceptances", (o,n) => { (o as TermsOfUseContainer).AgreementAcceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>().ToList(); } },
                {"agreements", (o,n) => { (o as TermsOfUseContainer).Agreements = n.GetCollectionOfObjectValues<Agreement>().ToList(); } },
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
