using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityApiConnector : Entity, IParsable {
        /// <summary>The object which describes the authentication configuration details for calling the API. Basic and PKCS 12 client certificate are supported.</summary>
        public ApiAuthenticationConfigurationBase AuthenticationConfiguration { get; set; }
        /// <summary>The name of the API connector.</summary>
        public string DisplayName { get; set; }
        /// <summary>The URL of the API endpoint to call.</summary>
        public string TargetUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authenticationConfiguration", (o,n) => { (o as IdentityApiConnector).AuthenticationConfiguration = n.GetObjectValue<ApiAuthenticationConfigurationBase>(); } },
                {"displayName", (o,n) => { (o as IdentityApiConnector).DisplayName = n.GetStringValue(); } },
                {"targetUrl", (o,n) => { (o as IdentityApiConnector).TargetUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiAuthenticationConfigurationBase>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("targetUrl", TargetUrl);
        }
    }
}
