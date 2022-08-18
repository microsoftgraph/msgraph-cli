using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ConditionalAccessUsers : IAdditionalDataHolder, IParsable {
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
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessUsers and sets the default values.
        /// </summary>
        public ConditionalAccessUsers() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.conditionalAccessUsers";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeRoles", n => { ExcludeRoles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeUsers", n => { ExcludeUsers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeRoles", n => { IncludeRoles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeUsers", n => { IncludeUsers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
