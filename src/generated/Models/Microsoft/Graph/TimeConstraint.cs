using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeConstraint : IAdditionalDataHolder, IParsable {
        /// <summary>The nature of the activity, optional. The possible values are: work, personal, unrestricted, or unknown.</summary>
        public ApiSdk.Models.Microsoft.Graph.ActivityDomain? ActivityDomain { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.TimeSlot> TimeSlots { get; set; }
        /// <summary>
        /// Instantiates a new timeConstraint and sets the default values.
        /// </summary>
        public TimeConstraint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.TimeConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityDomain", (o,n) => { (o as TimeConstraint).ActivityDomain = n.GetEnumValue<ActivityDomain>(); } },
                {"timeSlots", (o,n) => { (o as TimeConstraint).TimeSlots = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeSlot>(ApiSdk.Models.Microsoft.Graph.TimeSlot.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ActivityDomain>("activityDomain", ActivityDomain);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeSlot>("timeSlots", TimeSlots);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
