using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Authentication : Entity, IParsable {
        public List<Fido2AuthenticationMethod> Fido2Methods { get; set; }
        public List<AuthenticationMethod> Methods { get; set; }
        public List<MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods { get; set; }
        public List<WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fido2Methods", (o,n) => { (o as Authentication).Fido2Methods = n.GetCollectionOfObjectValues<Fido2AuthenticationMethod>().ToList(); } },
                {"methods", (o,n) => { (o as Authentication).Methods = n.GetCollectionOfObjectValues<AuthenticationMethod>().ToList(); } },
                {"microsoftAuthenticatorMethods", (o,n) => { (o as Authentication).MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>().ToList(); } },
                {"windowsHelloForBusinessMethods", (o,n) => { (o as Authentication).WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Fido2AuthenticationMethod>("fido2Methods", Fido2Methods);
            writer.WriteCollectionOfObjectValues<AuthenticationMethod>("methods", Methods);
            writer.WriteCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>("microsoftAuthenticatorMethods", MicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>("windowsHelloForBusinessMethods", WindowsHelloForBusinessMethods);
        }
    }
}
