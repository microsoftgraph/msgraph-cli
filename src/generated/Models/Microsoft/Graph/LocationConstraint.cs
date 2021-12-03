using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LocationConstraint : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isRequired", (o,n) => { (o as LocationConstraint).IsRequired = n.GetBoolValue(); } },
                {"locations", (o,n) => { (o as LocationConstraint).Locations = n.GetCollectionOfObjectValues<LocationConstraintItem>().ToList(); } },
                {"suggestLocation", (o,n) => { (o as LocationConstraint).SuggestLocation = n.GetBoolValue(); } },
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
