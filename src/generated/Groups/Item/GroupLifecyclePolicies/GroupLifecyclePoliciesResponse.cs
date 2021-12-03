using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.GroupLifecyclePolicies {
    public class GroupLifecyclePoliciesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<GroupLifecyclePolicy> Value { get; set; }
        /// <summary>
        /// Instantiates a new groupLifecyclePoliciesResponse and sets the default values.
        /// </summary>
        public GroupLifecyclePoliciesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as GroupLifecyclePoliciesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as GroupLifecyclePoliciesResponse).Value = n.GetCollectionOfObjectValues<GroupLifecyclePolicy>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<GroupLifecyclePolicy>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
