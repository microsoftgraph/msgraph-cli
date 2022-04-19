using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ISO 3166-1 Alpha-2 country code of the participant&apos;s best estimated physical location at the start of the call. Read-only.</summary>
        public string CountryCode { get; set; }
        /// <summary>The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.</summary>
        public ApiSdk.Models.EndpointType? EndpointType { get; set; }
        /// <summary>The identity property</summary>
        public IdentitySet Identity { get; set; }
        /// <summary>The language culture string. Read-only.</summary>
        public string LanguageId { get; set; }
        /// <summary>The participant ID of the participant. Read-only.</summary>
        public string ParticipantId { get; set; }
        /// <summary>The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant&apos;s current physical location. Read-only.</summary>
        public string Region { get; set; }
        /// <summary>
        /// Instantiates a new participantInfo and sets the default values.
        /// </summary>
        public ParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"languageId", n => { LanguageId = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("languageId", LanguageId);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteStringValue("region", Region);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
