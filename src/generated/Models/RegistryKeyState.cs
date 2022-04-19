using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RegistryKeyState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A Windows registry hive : HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE/SAM HKEY_LOCAL_MACHINE/Security HKEY_LOCAL_MACHINE/Software HKEY_LOCAL_MACHINE/System HKEY_USERS/.Default. Possible values are: unknown, currentConfig, currentUser, localMachineSam, localMachineSecurity, localMachineSoftware, localMachineSystem, usersDefault.</summary>
        public RegistryHive? Hive { get; set; }
        /// <summary>Current (i.e. changed) registry key (excludes HIVE).</summary>
        public string Key { get; set; }
        /// <summary>Previous (i.e. before changed) registry key (excludes HIVE).</summary>
        public string OldKey { get; set; }
        /// <summary>Previous (i.e. before changed) registry key value data (contents).</summary>
        public string OldValueData { get; set; }
        /// <summary>Previous (i.e. before changed) registry key value name.</summary>
        public string OldValueName { get; set; }
        /// <summary>Operation that changed the registry key name and/or value. Possible values are: unknown, create, modify, delete.</summary>
        public RegistryOperation? Operation { get; set; }
        /// <summary>Process ID (PID) of the process that modified the registry key (process details will appear in the alert &apos;processes&apos; collection).</summary>
        public int? ProcessId { get; set; }
        /// <summary>Current (i.e. changed) registry key value data (contents).</summary>
        public string ValueData { get; set; }
        /// <summary>Current (i.e. changed) registry key value name</summary>
        public string ValueName { get; set; }
        /// <summary>Registry key value type REG_BINARY REG_DWORD REG_DWORD_LITTLE_ENDIAN REG_DWORD_BIG_ENDIANREG_EXPAND_SZ REG_LINK REG_MULTI_SZ REG_NONE REG_QWORD REG_QWORD_LITTLE_ENDIAN REG_SZ Possible values are: unknown, binary, dword, dwordLittleEndian, dwordBigEndian, expandSz, link, multiSz, none, qword, qwordlittleEndian, sz.</summary>
        public RegistryValueType? ValueType { get; set; }
        /// <summary>
        /// Instantiates a new registryKeyState and sets the default values.
        /// </summary>
        public RegistryKeyState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RegistryKeyState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistryKeyState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hive", n => { Hive = n.GetEnumValue<RegistryHive>(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"oldKey", n => { OldKey = n.GetStringValue(); } },
                {"oldValueData", n => { OldValueData = n.GetStringValue(); } },
                {"oldValueName", n => { OldValueName = n.GetStringValue(); } },
                {"operation", n => { Operation = n.GetEnumValue<RegistryOperation>(); } },
                {"processId", n => { ProcessId = n.GetIntValue(); } },
                {"valueData", n => { ValueData = n.GetStringValue(); } },
                {"valueName", n => { ValueName = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<RegistryValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RegistryHive>("hive", Hive);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("oldKey", OldKey);
            writer.WriteStringValue("oldValueData", OldValueData);
            writer.WriteStringValue("oldValueName", OldValueName);
            writer.WriteEnumValue<RegistryOperation>("operation", Operation);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteStringValue("valueData", ValueData);
            writer.WriteStringValue("valueName", ValueName);
            writer.WriteEnumValue<RegistryValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
