using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkforceIntegration : ChangeTrackedEntity, IParsable {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion { get; set; }
        /// <summary>Name of the workforce integration.</summary>
        public string DisplayName { get; set; }
        /// <summary>The workforce integration encryption resource.</summary>
        public WorkforceIntegrationEncryption Encryption { get; set; }
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. Possible values are: none, shift, swapRequest, userShiftPreferences, openshift, openShiftRequest, offerShiftRequest, unknownFutureValue.</summary>
        public WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Instantiates a new WorkforceIntegration and sets the default values.
        /// </summary>
        public WorkforceIntegration() : base() {
            OdataType = "#microsoft.graph.workforceIntegration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkforceIntegration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkforceIntegration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apiVersion", n => { ApiVersion = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"encryption", n => { Encryption = n.GetObjectValue<WorkforceIntegrationEncryption>(WorkforceIntegrationEncryption.CreateFromDiscriminatorValue); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"supportedEntities", n => { SupportedEntities = n.GetEnumValue<WorkforceIntegrationSupportedEntities>(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("apiVersion", ApiVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<WorkforceIntegrationEncryption>("encryption", Encryption);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteEnumValue<WorkforceIntegrationSupportedEntities>("supportedEntities", SupportedEntities);
            writer.WriteStringValue("url", Url);
        }
    }
}
