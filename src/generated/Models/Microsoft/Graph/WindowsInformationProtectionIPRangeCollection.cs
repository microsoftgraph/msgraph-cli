using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionIPRangeCollection : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of ip ranges</summary>
        public List<IpRange> Ranges { get; set; }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionIPRangeCollection and sets the default values.
        /// </summary>
        public WindowsInformationProtectionIPRangeCollection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsInformationProtectionIPRangeCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionIPRangeCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as WindowsInformationProtectionIPRangeCollection).DisplayName = n.GetStringValue(); } },
                {"ranges", (o,n) => { (o as WindowsInformationProtectionIPRangeCollection).Ranges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<IpRange>("ranges", Ranges);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
