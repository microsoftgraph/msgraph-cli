using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RegistryKeyState : IParsable {
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
        /// <summary>Process ID (PID) of the process that modified the registry key (process details will appear in the alert 'processes' collection).</summary>
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hive", (o,n) => { (o as RegistryKeyState).Hive = n.GetEnumValue<RegistryHive>(); } },
                {"key", (o,n) => { (o as RegistryKeyState).Key = n.GetStringValue(); } },
                {"oldKey", (o,n) => { (o as RegistryKeyState).OldKey = n.GetStringValue(); } },
                {"oldValueData", (o,n) => { (o as RegistryKeyState).OldValueData = n.GetStringValue(); } },
                {"oldValueName", (o,n) => { (o as RegistryKeyState).OldValueName = n.GetStringValue(); } },
                {"operation", (o,n) => { (o as RegistryKeyState).Operation = n.GetEnumValue<RegistryOperation>(); } },
                {"processId", (o,n) => { (o as RegistryKeyState).ProcessId = n.GetIntValue(); } },
                {"valueData", (o,n) => { (o as RegistryKeyState).ValueData = n.GetStringValue(); } },
                {"valueName", (o,n) => { (o as RegistryKeyState).ValueName = n.GetStringValue(); } },
                {"valueType", (o,n) => { (o as RegistryKeyState).ValueType = n.GetEnumValue<RegistryValueType>(); } },
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
