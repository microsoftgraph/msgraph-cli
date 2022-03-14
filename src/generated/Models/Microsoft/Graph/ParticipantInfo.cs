using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.</summary>
        public string CountryCode { get; set; }
        /// <summary>The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.EndpointType? EndpointType { get; set; }
        public IdentitySet Identity { get; set; }
        /// <summary>The language culture string. Read-only.</summary>
        public string LanguageId { get; set; }
        /// <summary>The participant ID of the participant. Read-only.</summary>
        public string ParticipantId { get; set; }
        /// <summary>The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.</summary>
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"countryCode", (o,n) => { (o as ParticipantInfo).CountryCode = n.GetStringValue(); } },
                {"endpointType", (o,n) => { (o as ParticipantInfo).EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"identity", (o,n) => { (o as ParticipantInfo).Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"languageId", (o,n) => { (o as ParticipantInfo).LanguageId = n.GetStringValue(); } },
                {"participantId", (o,n) => { (o as ParticipantInfo).ParticipantId = n.GetStringValue(); } },
                {"region", (o,n) => { (o as ParticipantInfo).Region = n.GetStringValue(); } },
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
