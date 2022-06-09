using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MediaContentRatingAustralia : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Movies rating selected for Australia. Possible values are: allAllowed, allBlocked, general, parentalGuidance, mature, agesAbove15, agesAbove18.</summary>
        public RatingAustraliaMoviesType? MovieRating { get; set; }
        /// <summary>TV rating selected for Australia. Possible values are: allAllowed, allBlocked, preschoolers, children, general, parentalGuidance, mature, agesAbove15, agesAbove15AdultViolence.</summary>
        public RatingAustraliaTelevisionType? TvRating { get; set; }
        /// <summary>
        /// Instantiates a new mediaContentRatingAustralia and sets the default values.
        /// </summary>
        public MediaContentRatingAustralia() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingAustralia CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingAustralia();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingAustraliaMoviesType>(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingAustraliaTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingAustraliaMoviesType>("movieRating", MovieRating);
            writer.WriteEnumValue<RatingAustraliaTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
