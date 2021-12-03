using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamFunSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, enables users to include custom memes.</summary>
        public bool? AllowCustomMemes { get; set; }
        /// <summary>If set to true, enables Giphy use.</summary>
        public bool? AllowGiphy { get; set; }
        /// <summary>If set to true, enables users to include stickers and memes.</summary>
        public bool? AllowStickersAndMemes { get; set; }
        /// <summary>Giphy content rating. Possible values are: moderate, strict.</summary>
        public GiphyRatingType? GiphyContentRating { get; set; }
        /// <summary>
        /// Instantiates a new teamFunSettings and sets the default values.
        /// </summary>
        public TeamFunSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowCustomMemes", (o,n) => { (o as TeamFunSettings).AllowCustomMemes = n.GetBoolValue(); } },
                {"allowGiphy", (o,n) => { (o as TeamFunSettings).AllowGiphy = n.GetBoolValue(); } },
                {"allowStickersAndMemes", (o,n) => { (o as TeamFunSettings).AllowStickersAndMemes = n.GetBoolValue(); } },
                {"giphyContentRating", (o,n) => { (o as TeamFunSettings).GiphyContentRating = n.GetEnumValue<GiphyRatingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomMemes", AllowCustomMemes);
            writer.WriteBoolValue("allowGiphy", AllowGiphy);
            writer.WriteBoolValue("allowStickersAndMemes", AllowStickersAndMemes);
            writer.WriteEnumValue<GiphyRatingType>("giphyContentRating", GiphyContentRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
