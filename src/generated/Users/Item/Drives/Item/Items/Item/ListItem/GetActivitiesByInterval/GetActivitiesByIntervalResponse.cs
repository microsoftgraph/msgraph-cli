using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Drives.Item.Items.Item.ListItem.GetActivitiesByInterval {
    /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
    public class GetActivitiesByIntervalResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ItemActivityStat> Value { get; set; }
        /// <summary>
        /// Instantiates a new getActivitiesByIntervalResponse and sets the default values.
        /// </summary>
        public GetActivitiesByIntervalResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Users.Item.Drives.Item.Items.Item.ListItem.GetActivitiesByInterval.GetActivitiesByIntervalResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetActivitiesByIntervalResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as GetActivitiesByIntervalResponse).Value = n.GetCollectionOfObjectValues<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ItemActivityStat>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
