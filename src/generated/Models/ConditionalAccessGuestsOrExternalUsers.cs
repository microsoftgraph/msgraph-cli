using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ConditionalAccessGuestsOrExternalUsers : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The externalTenants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessExternalTenants? ExternalTenants { get; set; }
#nullable restore
#else
        public ConditionalAccessExternalTenants ExternalTenants { get; set; }
#endif
        /// <summary>The guestOrExternalUserTypes property</summary>
        public ConditionalAccessGuestOrExternalUserTypes? GuestOrExternalUserTypes { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessGuestsOrExternalUsers and sets the default values.
        /// </summary>
        public ConditionalAccessGuestsOrExternalUsers() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessGuestsOrExternalUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessGuestsOrExternalUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"externalTenants", n => { ExternalTenants = n.GetObjectValue<ConditionalAccessExternalTenants>(ConditionalAccessExternalTenants.CreateFromDiscriminatorValue); } },
                {"guestOrExternalUserTypes", n => { GuestOrExternalUserTypes = n.GetEnumValue<ConditionalAccessGuestOrExternalUserTypes>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessExternalTenants>("externalTenants", ExternalTenants);
            writer.WriteEnumValue<ConditionalAccessGuestOrExternalUserTypes>("guestOrExternalUserTypes", GuestOrExternalUserTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}