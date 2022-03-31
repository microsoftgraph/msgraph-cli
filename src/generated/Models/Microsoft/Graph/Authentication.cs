using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Authentication : Entity, IParsable {
        /// <summary>Represents the FIDO2 security keys registered to a user for authentication.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Fido2AuthenticationMethod> Fido2Methods { get; set; }
        /// <summary>Represents all authentication methods registered to a user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AuthenticationMethod> Methods { get; set; }
        /// <summary>The details of the Microsoft Authenticator app registered to a user for authentication.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods { get; set; }
        /// <summary>Represents the Windows Hello for Business authentication method registered to a user for authentication.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Authentication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Authentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fido2Methods", (o,n) => { (o as Authentication).Fido2Methods = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Fido2AuthenticationMethod>(ApiSdk.Models.Microsoft.Graph.Fido2AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"methods", (o,n) => { (o as Authentication).Methods = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AuthenticationMethod>(ApiSdk.Models.Microsoft.Graph.AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftAuthenticatorMethods", (o,n) => { (o as Authentication).MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MicrosoftAuthenticatorAuthenticationMethod>(ApiSdk.Models.Microsoft.Graph.MicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsHelloForBusinessMethods", (o,n) => { (o as Authentication).WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsHelloForBusinessAuthenticationMethod>(ApiSdk.Models.Microsoft.Graph.WindowsHelloForBusinessAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Fido2AuthenticationMethod>("fido2Methods", Fido2Methods);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AuthenticationMethod>("methods", Methods);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MicrosoftAuthenticatorAuthenticationMethod>("microsoftAuthenticatorMethods", MicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsHelloForBusinessAuthenticationMethod>("windowsHelloForBusinessMethods", WindowsHelloForBusinessMethods);
        }
    }
}
