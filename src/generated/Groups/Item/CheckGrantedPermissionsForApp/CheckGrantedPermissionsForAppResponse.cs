using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.CheckGrantedPermissionsForApp {
    /// <summary>Provides operations to call the checkGrantedPermissionsForApp method.</summary>
    public class CheckGrantedPermissionsForAppResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ResourceSpecificPermissionGrant> Value { get; set; }
        /// <summary>
        /// Instantiates a new checkGrantedPermissionsForAppResponse and sets the default values.
        /// </summary>
        public CheckGrantedPermissionsForAppResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Groups.Item.CheckGrantedPermissionsForApp.CheckGrantedPermissionsForAppResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckGrantedPermissionsForAppResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as CheckGrantedPermissionsForAppResponse).Value = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>(ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
