using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Audio : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The title of the album for this audio file.</summary>
        public string Album { get; set; }
        /// <summary>The artist named on the album for the audio file.</summary>
        public string AlbumArtist { get; set; }
        /// <summary>The performing artist for the audio file.</summary>
        public string Artist { get; set; }
        /// <summary>Bitrate expressed in kbps.</summary>
        public long? Bitrate { get; set; }
        /// <summary>The name of the composer of the audio file.</summary>
        public string Composers { get; set; }
        /// <summary>Copyright information for the audio file.</summary>
        public string Copyright { get; set; }
        /// <summary>The number of the disc this audio file came from.</summary>
        public int? Disc { get; set; }
        /// <summary>The total number of discs in this album.</summary>
        public int? DiscCount { get; set; }
        /// <summary>Duration of the audio file, expressed in milliseconds</summary>
        public long? Duration { get; set; }
        /// <summary>The genre of this audio file.</summary>
        public string Genre { get; set; }
        /// <summary>Indicates if the file is protected with digital rights management.</summary>
        public bool? HasDrm { get; set; }
        /// <summary>Indicates if the file is encoded with a variable bitrate.</summary>
        public bool? IsVariableBitrate { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The title of the audio file.</summary>
        public string Title { get; set; }
        /// <summary>The number of the track on the original disc for this audio file.</summary>
        public int? Track { get; set; }
        /// <summary>The total number of tracks on the original disc for this audio file.</summary>
        public int? TrackCount { get; set; }
        /// <summary>The year the audio file was recorded.</summary>
        public int? Year { get; set; }
        /// <summary>
        /// Instantiates a new audio and sets the default values.
        /// </summary>
        public Audio() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.audio";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Audio CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Audio();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"album", n => { Album = n.GetStringValue(); } },
                {"albumArtist", n => { AlbumArtist = n.GetStringValue(); } },
                {"artist", n => { Artist = n.GetStringValue(); } },
                {"bitrate", n => { Bitrate = n.GetLongValue(); } },
                {"composers", n => { Composers = n.GetStringValue(); } },
                {"copyright", n => { Copyright = n.GetStringValue(); } },
                {"disc", n => { Disc = n.GetIntValue(); } },
                {"discCount", n => { DiscCount = n.GetIntValue(); } },
                {"duration", n => { Duration = n.GetLongValue(); } },
                {"genre", n => { Genre = n.GetStringValue(); } },
                {"hasDrm", n => { HasDrm = n.GetBoolValue(); } },
                {"isVariableBitrate", n => { IsVariableBitrate = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"track", n => { Track = n.GetIntValue(); } },
                {"trackCount", n => { TrackCount = n.GetIntValue(); } },
                {"year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("album", Album);
            writer.WriteStringValue("albumArtist", AlbumArtist);
            writer.WriteStringValue("artist", Artist);
            writer.WriteLongValue("bitrate", Bitrate);
            writer.WriteStringValue("composers", Composers);
            writer.WriteStringValue("copyright", Copyright);
            writer.WriteIntValue("disc", Disc);
            writer.WriteIntValue("discCount", DiscCount);
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("genre", Genre);
            writer.WriteBoolValue("hasDrm", HasDrm);
            writer.WriteBoolValue("isVariableBitrate", IsVariableBitrate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("track", Track);
            writer.WriteIntValue("trackCount", TrackCount);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
