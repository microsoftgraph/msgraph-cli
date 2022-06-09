using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MediaContentRatingGermany : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Movies rating selected for Germany. Possible values are: allAllowed, allBlocked, general, agesAbove6, agesAbove12, agesAbove16, adults.</summary>
        public RatingGermanyMoviesType? MovieRating { get; set; }
        /// <summary>TV rating selected for Germany. Possible values are: allAllowed, allBlocked, general, agesAbove6, agesAbove12, agesAbove16, adults.</summary>
        public RatingGermanyTelevisionType? TvRating { get; set; }
        /// <summary>
        /// Instantiates a new mediaContentRatingGermany and sets the default values.
        /// </summary>
        public MediaContentRatingGermany() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingGermany CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingGermany();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingGermanyMoviesType>(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingGermanyTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingGermanyMoviesType>("movieRating", MovieRating);
            writer.WriteEnumValue<RatingGermanyTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
