using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UnifiedRolePermission : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Set of tasks that can be performed on a resource. Required.</summary>
        public List<string> AllowedResourceActions { get; set; }
        /// <summary>Optional constraints that must be met for the permission to be effective.</summary>
        public string Condition { get; set; }
        /// <summary>Set of tasks that may not be performed on a resource. Not yet supported.</summary>
        public List<string> ExcludedResourceActions { get; set; }
        /// <summary>
        /// Instantiates a new unifiedRolePermission and sets the default values.
        /// </summary>
        public UnifiedRolePermission() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedResourceActions", (o,n) => { (o as UnifiedRolePermission).AllowedResourceActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"condition", (o,n) => { (o as UnifiedRolePermission).Condition = n.GetStringValue(); } },
                {"excludedResourceActions", (o,n) => { (o as UnifiedRolePermission).ExcludedResourceActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedResourceActions", AllowedResourceActions);
            writer.WriteStringValue("condition", Condition);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedResourceActions", ExcludedResourceActions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
