using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Pkcs12Certificate : ApiAuthenticationConfigurationBase, IParsable {
        /// <summary>The password for the pfx file. Required. If no password is used, you must still provide a value of &apos;&apos;.</summary>
        public string Password { get; set; }
        /// <summary>Represents the pfx content that is sent. The value should be a base-64 encoded version of the actual certificate content. Required.</summary>
        public string Pkcs12Value { get; set; }
        /// <summary>
        /// Instantiates a new Pkcs12Certificate and sets the default values.
        /// </summary>
        public Pkcs12Certificate() : base() {
            OdataType = "#microsoft.graph.pkcs12Certificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Pkcs12Certificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pkcs12Certificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"password", n => { Password = n.GetStringValue(); } },
                {"pkcs12Value", n => { Pkcs12Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("pkcs12Value", Pkcs12Value);
        }
    }
}
