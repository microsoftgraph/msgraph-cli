using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessUsers : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Group IDs excluded from scope of policy.</summary>
        public List<string> ExcludeGroups { get; set; }
        /// <summary>Role IDs excluded from scope of policy.</summary>
        public List<string> ExcludeRoles { get; set; }
        /// <summary>User IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
        public List<string> ExcludeUsers { get; set; }
        /// <summary>Group IDs in scope of policy unless explicitly excluded, or All.</summary>
        public List<string> IncludeGroups { get; set; }
        /// <summary>Role IDs in scope of policy unless explicitly excluded, or All.</summary>
        public List<string> IncludeRoles { get; set; }
        /// <summary>User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.</summary>
        public List<string> IncludeUsers { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessUsers and sets the default values.
        /// </summary>
        public ConditionalAccessUsers() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeGroups", (o,n) => { (o as ConditionalAccessUsers).ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeRoles", (o,n) => { (o as ConditionalAccessUsers).ExcludeRoles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeUsers", (o,n) => { (o as ConditionalAccessUsers).ExcludeUsers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeGroups", (o,n) => { (o as ConditionalAccessUsers).IncludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeRoles", (o,n) => { (o as ConditionalAccessUsers).IncludeRoles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeUsers", (o,n) => { (o as ConditionalAccessUsers).IncludeUsers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeRoles", ExcludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeUsers", ExcludeUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteCollectionOfPrimitiveValues<string>("includeRoles", IncludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUsers", IncludeUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
