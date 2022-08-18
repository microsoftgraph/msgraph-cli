using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Room : Place, IParsable {
        /// <summary>Specifies the name of the audio device in the room.</summary>
        public string AudioDeviceName { get; set; }
        /// <summary>Type of room. Possible values are standard, and reserved.</summary>
        public ApiSdk.Models.BookingType? BookingType { get; set; }
        /// <summary>Specifies the building name or building number that the room is in.</summary>
        public string Building { get; set; }
        /// <summary>Specifies the capacity of the room.</summary>
        public int? Capacity { get; set; }
        /// <summary>Specifies the name of the display device in the room.</summary>
        public string DisplayDeviceName { get; set; }
        /// <summary>Email address of the room.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Specifies a descriptive label for the floor, for example, P.</summary>
        public string FloorLabel { get; set; }
        /// <summary>Specifies the floor number that the room is on.</summary>
        public int? FloorNumber { get; set; }
        /// <summary>Specifies whether the room is wheelchair accessible.</summary>
        public bool? IsWheelChairAccessible { get; set; }
        /// <summary>Specifies a descriptive label for the room, for example, a number or name.</summary>
        public string Label { get; set; }
        /// <summary>Specifies a nickname for the room, for example, &apos;conf room&apos;.</summary>
        public string Nickname { get; set; }
        /// <summary>Specifies additional features of the room, for example, details like the type of view or furniture type.</summary>
        public List<string> Tags { get; set; }
        /// <summary>Specifies the name of the video device in the room.</summary>
        public string VideoDeviceName { get; set; }
        /// <summary>
        /// Instantiates a new Room and sets the default values.
        /// </summary>
        public Room() : base() {
            OdataType = "#microsoft.graph.room";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Room CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Room();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audioDeviceName", n => { AudioDeviceName = n.GetStringValue(); } },
                {"bookingType", n => { BookingType = n.GetEnumValue<BookingType>(); } },
                {"building", n => { Building = n.GetStringValue(); } },
                {"capacity", n => { Capacity = n.GetIntValue(); } },
                {"displayDeviceName", n => { DisplayDeviceName = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"floorLabel", n => { FloorLabel = n.GetStringValue(); } },
                {"floorNumber", n => { FloorNumber = n.GetIntValue(); } },
                {"isWheelChairAccessible", n => { IsWheelChairAccessible = n.GetBoolValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"videoDeviceName", n => { VideoDeviceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("audioDeviceName", AudioDeviceName);
            writer.WriteEnumValue<BookingType>("bookingType", BookingType);
            writer.WriteStringValue("building", Building);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteStringValue("displayDeviceName", DisplayDeviceName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteStringValue("floorLabel", FloorLabel);
            writer.WriteIntValue("floorNumber", FloorNumber);
            writer.WriteBoolValue("isWheelChairAccessible", IsWheelChairAccessible);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("videoDeviceName", VideoDeviceName);
        }
    }
}
