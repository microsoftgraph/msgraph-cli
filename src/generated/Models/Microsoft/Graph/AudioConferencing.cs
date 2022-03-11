using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AudioConferencing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conference id of the online meeting.</summary>
        public string ConferenceId { get; set; }
        /// <summary>A URL to the externally-accessible web page that contains dial-in information.</summary>
        public string DialinUrl { get; set; }
        public string TollFreeNumber { get; set; }
        /// <summary>List of toll-free numbers that are displayed in the meeting invite.</summary>
        public List<string> TollFreeNumbers { get; set; }
        public string TollNumber { get; set; }
        /// <summary>List of toll numbers that are displayed in the meeting invite.</summary>
        public List<string> TollNumbers { get; set; }
        /// <summary>
        /// Instantiates a new audioConferencing and sets the default values.
        /// </summary>
        public AudioConferencing() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AudioConferencing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudioConferencing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"conferenceId", (o,n) => { (o as AudioConferencing).ConferenceId = n.GetStringValue(); } },
                {"dialinUrl", (o,n) => { (o as AudioConferencing).DialinUrl = n.GetStringValue(); } },
                {"tollFreeNumber", (o,n) => { (o as AudioConferencing).TollFreeNumber = n.GetStringValue(); } },
                {"tollFreeNumbers", (o,n) => { (o as AudioConferencing).TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tollNumber", (o,n) => { (o as AudioConferencing).TollNumber = n.GetStringValue(); } },
                {"tollNumbers", (o,n) => { (o as AudioConferencing).TollNumbers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("dialinUrl", DialinUrl);
            writer.WriteStringValue("tollFreeNumber", TollFreeNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollNumbers", TollNumbers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
