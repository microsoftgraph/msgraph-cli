using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TermsOfUseContainer : Entity, IParsable {
        public List<AgreementAcceptance> AgreementAcceptances { get; set; }
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
