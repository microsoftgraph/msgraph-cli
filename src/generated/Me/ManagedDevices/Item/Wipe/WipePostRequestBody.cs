using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.ManagedDevices.Item.Wipe {
    /// <summary>Provides operations to call the wipe method.</summary>
    public class WipePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData { get; set; }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData { get; set; }
        /// <summary>The macOsUnlockCode property</summary>
        public string MacOsUnlockCode { get; set; }
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>
        /// Instantiates a new wipePostRequestBody and sets the default values.
        /// </summary>
        public WipePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WipePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                {"macOsUnlockCode", n => { MacOsUnlockCode = n.GetStringValue(); } },
                {"persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("macOsUnlockCode", MacOsUnlockCode);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
