using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedMobileApp : Entity, IParsable {
        /// <summary>The identifier for an app with it's operating system type.</summary>
        public ApiSdk.Models.Microsoft.Graph.MobileAppIdentifier MobileAppIdentifier { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ManagedMobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedMobileApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"mobileAppIdentifier", (o,n) => { (o as ManagedMobileApp).MobileAppIdentifier = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MobileAppIdentifier>(ApiSdk.Models.Microsoft.Graph.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as ManagedMobileApp).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteStringValue("version", Version);
        }
    }
}
