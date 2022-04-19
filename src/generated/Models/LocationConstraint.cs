using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class LocationConstraint : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes will not return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>Constraint information for one or more locations that the client requests for the meeting.</summary>
        public List<LocationConstraintItem> Locations { get; set; }
        /// <summary>The client requests the service to suggest one or more meeting locations.</summary>
        public bool? SuggestLocation { get; set; }
        /// <summary>
        /// Instantiates a new locationConstraint and sets the default values.
        /// </summary>
        public LocationConstraint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LocationConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LocationConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<LocationConstraintItem>(LocationConstraintItem.CreateFromDiscriminatorValue).ToList(); } },
                {"suggestLocation", n => { SuggestLocation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteCollectionOfObjectValues<LocationConstraintItem>("locations", Locations);
            writer.WriteBoolValue("suggestLocation", SuggestLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
