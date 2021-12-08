using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DetectedApp : Entity, IParsable {
        /// <summary>The number of devices that have installed this application</summary>
        public int? DeviceCount { get; set; }
        /// <summary>Name of the discovered application. Read-only</summary>
        public string DisplayName { get; set; }
        /// <summary>The devices that have the discovered application installed</summary>
        public List<ManagedDevice> ManagedDevices { get; set; }
        /// <summary>Discovered application size in bytes. Read-only</summary>
        public long? SizeInByte { get; set; }
        /// <summary>Version of the discovered application. Read-only</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceCount", (o,n) => { (o as DetectedApp).DeviceCount = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as DetectedApp).DisplayName = n.GetStringValue(); } },
                {"managedDevices", (o,n) => { (o as DetectedApp).ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>().ToList(); } },
                {"sizeInByte", (o,n) => { (o as DetectedApp).SizeInByte = n.GetLongValue(); } },
                {"version", (o,n) => { (o as DetectedApp).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteLongValue("sizeInByte", SizeInByte);
            writer.WriteStringValue("version", Version);
        }
    }
}
