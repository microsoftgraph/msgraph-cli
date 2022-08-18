using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Shared : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The identity of the owner of the shared item. Read-only.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Indicates the scope of how the item is shared: anonymous, organization, or users. Read-only.</summary>
        public string Scope { get; set; }
        /// <summary>The identity of the user who shared the item. Read-only.</summary>
        public IdentitySet SharedBy { get; set; }
        /// <summary>The UTC date and time when the item was shared. Read-only.</summary>
        public DateTimeOffset? SharedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new shared and sets the default values.
        /// </summary>
        public Shared() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.shared";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Shared CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Shared();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"sharedBy", n => { SharedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"sharedDateTime", n => { SharedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteStringValue("scope", Scope);
            writer.WriteObjectValue<IdentitySet>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
