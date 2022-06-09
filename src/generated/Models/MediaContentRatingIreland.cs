using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MediaContentRatingIreland : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Movies rating selected for Ireland. Possible values are: allAllowed, allBlocked, general, parentalGuidance, agesAbove12, agesAbove15, agesAbove16, adults.</summary>
        public RatingIrelandMoviesType? MovieRating { get; set; }
        /// <summary>TV rating selected for Ireland. Possible values are: allAllowed, allBlocked, general, children, youngAdults, parentalSupervision, mature.</summary>
        public RatingIrelandTelevisionType? TvRating { get; set; }
        /// <summary>
        /// Instantiates a new mediaContentRatingIreland and sets the default values.
        /// </summary>
        public MediaContentRatingIreland() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingIreland CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingIreland();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingIrelandMoviesType>(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingIrelandTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingIrelandMoviesType>("movieRating", MovieRating);
            writer.WriteEnumValue<RatingIrelandTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
