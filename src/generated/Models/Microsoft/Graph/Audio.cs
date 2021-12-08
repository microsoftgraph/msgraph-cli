using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Audio : IParsable {
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
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"album", (o,n) => { (o as Audio).Album = n.GetStringValue(); } },
                {"albumArtist", (o,n) => { (o as Audio).AlbumArtist = n.GetStringValue(); } },
                {"artist", (o,n) => { (o as Audio).Artist = n.GetStringValue(); } },
                {"bitrate", (o,n) => { (o as Audio).Bitrate = n.GetLongValue(); } },
                {"composers", (o,n) => { (o as Audio).Composers = n.GetStringValue(); } },
                {"copyright", (o,n) => { (o as Audio).Copyright = n.GetStringValue(); } },
                {"disc", (o,n) => { (o as Audio).Disc = n.GetIntValue(); } },
                {"discCount", (o,n) => { (o as Audio).DiscCount = n.GetIntValue(); } },
                {"duration", (o,n) => { (o as Audio).Duration = n.GetLongValue(); } },
                {"genre", (o,n) => { (o as Audio).Genre = n.GetStringValue(); } },
                {"hasDrm", (o,n) => { (o as Audio).HasDrm = n.GetBoolValue(); } },
                {"isVariableBitrate", (o,n) => { (o as Audio).IsVariableBitrate = n.GetBoolValue(); } },
                {"title", (o,n) => { (o as Audio).Title = n.GetStringValue(); } },
                {"track", (o,n) => { (o as Audio).Track = n.GetIntValue(); } },
                {"trackCount", (o,n) => { (o as Audio).TrackCount = n.GetIntValue(); } },
                {"year", (o,n) => { (o as Audio).Year = n.GetIntValue(); } },
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
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("track", Track);
            writer.WriteIntValue("trackCount", TrackCount);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
