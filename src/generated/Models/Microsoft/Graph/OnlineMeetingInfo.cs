using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnlineMeetingInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the conference.</summary>
        public string ConferenceId { get; set; }
        /// <summary>The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.</summary>
        public string JoinUrl { get; set; }
        /// <summary>All of the phone numbers associated with this conference.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>The pre-formatted quickdial for this call.</summary>
        public string QuickDial { get; set; }
        /// <summary>The toll free numbers that can be used to join the conference.</summary>
        public List<string> TollFreeNumbers { get; set; }
        /// <summary>The toll number that can be used to join the conference.</summary>
        public string TollNumber { get; set; }
        /// <summary>
        /// Instantiates a new onlineMeetingInfo and sets the default values.
        /// </summary>
        public OnlineMeetingInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"conferenceId", (o,n) => { (o as OnlineMeetingInfo).ConferenceId = n.GetStringValue(); } },
                {"joinUrl", (o,n) => { (o as OnlineMeetingInfo).JoinUrl = n.GetStringValue(); } },
                {"phones", (o,n) => { (o as OnlineMeetingInfo).Phones = n.GetCollectionOfObjectValues<Phone>().ToList(); } },
                {"quickDial", (o,n) => { (o as OnlineMeetingInfo).QuickDial = n.GetStringValue(); } },
                {"tollFreeNumbers", (o,n) => { (o as OnlineMeetingInfo).TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tollNumber", (o,n) => { (o as OnlineMeetingInfo).TollNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteStringValue("quickDial", QuickDial);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
