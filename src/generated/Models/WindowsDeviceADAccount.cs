using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WindowsDeviceADAccount : WindowsDeviceAccount, IParsable {
        /// <summary>Not yet documented</summary>
        public string DomainName { get; set; }
        /// <summary>Not yet documented</summary>
        public string UserName { get; set; }
        /// <summary>
        /// Instantiates a new WindowsDeviceADAccount and sets the default values.
        /// </summary>
        public WindowsDeviceADAccount() : base() {
            OdataType = "#microsoft.graph.windowsDeviceADAccount";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDeviceADAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDeviceADAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
