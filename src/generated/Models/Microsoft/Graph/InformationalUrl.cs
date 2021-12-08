using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InformationalUrl : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>CDN URL to the application's logo, Read-only.</summary>
        public string LogoUrl { get; set; }
        /// <summary>Link to the application's marketing page. For example, https://www.contoso.com/app/marketing</summary>
        public string MarketingUrl { get; set; }
        /// <summary>Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy</summary>
        public string PrivacyStatementUrl { get; set; }
        /// <summary>Link to the application's support page. For example, https://www.contoso.com/app/support</summary>
        public string SupportUrl { get; set; }
        /// <summary>Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice</summary>
        public string TermsOfServiceUrl { get; set; }
        /// <summary>
        /// Instantiates a new informationalUrl and sets the default values.
        /// </summary>
        public InformationalUrl() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"logoUrl", (o,n) => { (o as InformationalUrl).LogoUrl = n.GetStringValue(); } },
                {"marketingUrl", (o,n) => { (o as InformationalUrl).MarketingUrl = n.GetStringValue(); } },
                {"privacyStatementUrl", (o,n) => { (o as InformationalUrl).PrivacyStatementUrl = n.GetStringValue(); } },
                {"supportUrl", (o,n) => { (o as InformationalUrl).SupportUrl = n.GetStringValue(); } },
                {"termsOfServiceUrl", (o,n) => { (o as InformationalUrl).TermsOfServiceUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("logoUrl", LogoUrl);
            writer.WriteStringValue("marketingUrl", MarketingUrl);
            writer.WriteStringValue("privacyStatementUrl", PrivacyStatementUrl);
            writer.WriteStringValue("supportUrl", SupportUrl);
            writer.WriteStringValue("termsOfServiceUrl", TermsOfServiceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
