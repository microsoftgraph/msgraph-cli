using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AccessPackageAutomaticRequestSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The gracePeriodBeforeAccessRemoval property</summary>
        public TimeSpan? GracePeriodBeforeAccessRemoval { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The removeAccessWhenTargetLeavesAllowedTargets property</summary>
        public bool? RemoveAccessWhenTargetLeavesAllowedTargets { get; set; }
        /// <summary>The requestAccessForAllowedTargets property</summary>
        public bool? RequestAccessForAllowedTargets { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAutomaticRequestSettings and sets the default values.
        /// </summary>
        public AccessPackageAutomaticRequestSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.accessPackageAutomaticRequestSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAutomaticRequestSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAutomaticRequestSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"gracePeriodBeforeAccessRemoval", n => { GracePeriodBeforeAccessRemoval = n.GetTimeSpanValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"removeAccessWhenTargetLeavesAllowedTargets", n => { RemoveAccessWhenTargetLeavesAllowedTargets = n.GetBoolValue(); } },
                {"requestAccessForAllowedTargets", n => { RequestAccessForAllowedTargets = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("gracePeriodBeforeAccessRemoval", GracePeriodBeforeAccessRemoval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("removeAccessWhenTargetLeavesAllowedTargets", RemoveAccessWhenTargetLeavesAllowedTargets);
            writer.WriteBoolValue("requestAccessForAllowedTargets", RequestAccessForAllowedTargets);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
