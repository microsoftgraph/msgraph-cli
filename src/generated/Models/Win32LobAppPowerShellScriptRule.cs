using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Win32LobAppPowerShellScriptRule : Win32LobAppRule, IParsable {
        /// <summary>The script output comparison value. Do not specify a value if the rule is used for detection.</summary>
        public string ComparisonValue { get; set; }
        /// <summary>The display name for the rule. Do not specify this value if the rule is used for detection.</summary>
        public string DisplayName { get; set; }
        /// <summary>A value indicating whether a signature check is enforced.</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>Contains all supported Powershell Script output detection type.</summary>
        public Win32LobAppPowerShellScriptRuleOperationType? OperationType { get; set; }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppRuleOperator? Operator { get; set; }
        /// <summary>A value indicating whether the script should run as 32-bit.</summary>
        public bool? RunAs32Bit { get; set; }
        /// <summary>The execution context of the script. Do not specify this value if the rule is used for detection. Script detection rules will run in the same context as the associated app install context. Possible values are: system, user.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>The base64-encoded script content.</summary>
        public string ScriptContent { get; set; }
        /// <summary>
        /// Instantiates a new Win32LobAppPowerShellScriptRule and sets the default values.
        /// </summary>
        public Win32LobAppPowerShellScriptRule() : base() {
            OdataType = "#microsoft.graph.win32LobAppPowerShellScriptRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppPowerShellScriptRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppPowerShellScriptRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comparisonValue", n => { ComparisonValue = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<Win32LobAppPowerShellScriptRuleOperationType>(); } },
                {"operator", n => { Operator = n.GetEnumValue<Win32LobAppRuleOperator>(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"scriptContent", n => { ScriptContent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comparisonValue", ComparisonValue);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteEnumValue<Win32LobAppPowerShellScriptRuleOperationType>("operationType", OperationType);
            writer.WriteEnumValue<Win32LobAppRuleOperator>("operator", Operator);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteStringValue("scriptContent", ScriptContent);
        }
    }
}
