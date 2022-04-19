using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DriveRecipient : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).</summary>
        public string Alias { get; set; }
        /// <summary>The email address for the recipient, if the recipient has an associated email address.</summary>
        public string Email { get; set; }
        /// <summary>The unique identifier for the recipient in the directory.</summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// Instantiates a new driveRecipient and sets the default values.
        /// </summary>
        public DriveRecipient() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DriveRecipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alias", n => { Alias = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alias", Alias);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
