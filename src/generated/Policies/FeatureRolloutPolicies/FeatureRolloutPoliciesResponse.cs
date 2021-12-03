using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Policies.FeatureRolloutPolicies {
    public class FeatureRolloutPoliciesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<FeatureRolloutPolicy> Value { get; set; }
        /// <summary>
        /// Instantiates a new featureRolloutPoliciesResponse and sets the default values.
        /// </summary>
        public FeatureRolloutPoliciesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as FeatureRolloutPoliciesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as FeatureRolloutPoliciesResponse).Value = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
