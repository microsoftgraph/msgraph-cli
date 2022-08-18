using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class TeamworkApplicationIdentity : Identity, IParsable {
        /// <summary>Type of application that is referenced. Possible values are: aadApplication, bot, tenantBot, office365Connector, outgoingWebhook, and unknownFutureValue.</summary>
        public TeamworkApplicationIdentityType? ApplicationIdentityType { get; set; }
        /// <summary>
        /// Instantiates a new TeamworkApplicationIdentity and sets the default values.
        /// </summary>
        public TeamworkApplicationIdentity() : base() {
            OdataType = "#microsoft.graph.teamworkApplicationIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkApplicationIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkApplicationIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationIdentityType", n => { ApplicationIdentityType = n.GetEnumValue<TeamworkApplicationIdentityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamworkApplicationIdentityType>("applicationIdentityType", ApplicationIdentityType);
        }
    }
}
