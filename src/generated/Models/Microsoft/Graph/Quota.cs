using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Quota : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        public long? Deleted { get; set; }
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        public long? Remaining { get; set; }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        public string State { get; set; }
        /// <summary>Information about the drive's storage quota plans. Only in Personal OneDrive.</summary>
        public StoragePlanInformation StoragePlanInformation { get; set; }
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        public long? Total { get; set; }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        public long? Used { get; set; }
        /// <summary>
        /// Instantiates a new quota and sets the default values.
        /// </summary>
        public Quota() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deleted", (o,n) => { (o as Quota).Deleted = n.GetLongValue(); } },
                {"remaining", (o,n) => { (o as Quota).Remaining = n.GetLongValue(); } },
                {"state", (o,n) => { (o as Quota).State = n.GetStringValue(); } },
                {"storagePlanInformation", (o,n) => { (o as Quota).StoragePlanInformation = n.GetObjectValue<StoragePlanInformation>(); } },
                {"total", (o,n) => { (o as Quota).Total = n.GetLongValue(); } },
                {"used", (o,n) => { (o as Quota).Used = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deleted", Deleted);
            writer.WriteLongValue("remaining", Remaining);
            writer.WriteStringValue("state", State);
            writer.WriteObjectValue<StoragePlanInformation>("storagePlanInformation", StoragePlanInformation);
            writer.WriteLongValue("total", Total);
            writer.WriteLongValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
