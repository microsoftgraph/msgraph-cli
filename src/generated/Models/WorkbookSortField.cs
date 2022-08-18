using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkbookSortField : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents whether the sorting is done in an ascending fashion.</summary>
        public bool? Ascending { get; set; }
        /// <summary>Represents the color that is the target of the condition if the sorting is on font or cell color.</summary>
        public string Color { get; set; }
        /// <summary>Represents additional sorting options for this field. The possible values are: Normal, TextAsNumber.</summary>
        public string DataOption { get; set; }
        /// <summary>Represents the icon that is the target of the condition if the sorting is on the cell&apos;s icon.</summary>
        public WorkbookIcon Icon { get; set; }
        /// <summary>Represents the column (or row, depending on the sort orientation) that the condition is on. Represented as an offset from the first column (or row).</summary>
        public int? Key { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Represents the type of sorting of this condition. The possible values are: Value, CellColor, FontColor, Icon.</summary>
        public string SortOn { get; set; }
        /// <summary>
        /// Instantiates a new workbookSortField and sets the default values.
        /// </summary>
        public WorkbookSortField() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.workbookSortField";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WorkbookSortField CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookSortField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ascending", n => { Ascending = n.GetBoolValue(); } },
                {"color", n => { Color = n.GetStringValue(); } },
                {"dataOption", n => { DataOption = n.GetStringValue(); } },
                {"icon", n => { Icon = n.GetObjectValue<WorkbookIcon>(WorkbookIcon.CreateFromDiscriminatorValue); } },
                {"key", n => { Key = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sortOn", n => { SortOn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("ascending", Ascending);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("dataOption", DataOption);
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteIntValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sortOn", SortOn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
