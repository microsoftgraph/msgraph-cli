using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Win32LobAppFileSystemRule : Win32LobAppRule, IParsable {
        /// <summary>A value indicating whether to expand environment variables in the 32-bit context on 64-bit systems.</summary>
        public bool? Check32BitOn64System { get; set; }
        /// <summary>The file or folder comparison value.</summary>
        public string ComparisonValue { get; set; }
        /// <summary>The file or folder name to look up.</summary>
        public string FileOrFolderName { get; set; }
        /// <summary>Contains all supported file system detection type.</summary>
        public Win32LobAppFileSystemOperationType? OperationType { get; set; }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppRuleOperator? Operator { get; set; }
        /// <summary>The file or folder path to look up.</summary>
        public string PathObject { get; set; }
        /// <summary>
        /// Instantiates a new Win32LobAppFileSystemRule and sets the default values.
        /// </summary>
        public Win32LobAppFileSystemRule() : base() {
            OdataType = "#microsoft.graph.win32LobAppFileSystemRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppFileSystemRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppFileSystemRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                {"comparisonValue", n => { ComparisonValue = n.GetStringValue(); } },
                {"fileOrFolderName", n => { FileOrFolderName = n.GetStringValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<Win32LobAppFileSystemOperationType>(); } },
                {"operator", n => { Operator = n.GetEnumValue<Win32LobAppRuleOperator>(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteStringValue("comparisonValue", ComparisonValue);
            writer.WriteStringValue("fileOrFolderName", FileOrFolderName);
            writer.WriteEnumValue<Win32LobAppFileSystemOperationType>("operationType", OperationType);
            writer.WriteEnumValue<Win32LobAppRuleOperator>("operator", Operator);
            writer.WriteStringValue("path", PathObject);
        }
    }
}
