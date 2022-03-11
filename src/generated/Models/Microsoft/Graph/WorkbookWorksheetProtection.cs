using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookWorksheetProtection : Entity, IParsable {
        /// <summary>Sheet protection options. Read-only.</summary>
        public WorkbookWorksheetProtectionOptions Options { get; set; }
        /// <summary>Indicates if the worksheet is protected.  Read-only.</summary>
        public bool? Protected { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookWorksheetProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheetProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"options", (o,n) => { (o as WorkbookWorksheetProtection).Options = n.GetObjectValue<WorkbookWorksheetProtectionOptions>(WorkbookWorksheetProtectionOptions.CreateFromDiscriminatorValue); } },
                {"protected", (o,n) => { (o as WorkbookWorksheetProtection).Protected = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookWorksheetProtectionOptions>("options", Options);
            writer.WriteBoolValue("protected", Protected);
        }
    }
}
