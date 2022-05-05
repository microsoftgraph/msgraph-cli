using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BitlockerRecoveryKey : Entity, IParsable {
        /// <summary>The date and time when the key was originally backed up to Azure Active Directory.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>ID of the device the BitLocker key is originally backed up from.</summary>
        public string DeviceId { get; set; }
        /// <summary>The BitLocker recovery key.</summary>
        public string Key { get; set; }
        /// <summary>Indicates the type of volume the BitLocker key is associated with. Possible values are: operatingSystemVolume, fixedDataVolume, removableDataVolume, unknownFutureValue.</summary>
        public ApiSdk.Models.VolumeType? VolumeType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BitlockerRecoveryKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitlockerRecoveryKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"volumeType", n => { VolumeType = n.GetEnumValue<VolumeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("key", Key);
            writer.WriteEnumValue<VolumeType>("volumeType", VolumeType);
        }
    }
}
