using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookRangeBorder : Entity, IParsable {
        /// <summary>HTML color code representing the color of the border line, of the form #RRGGBB (e.g. 'FFA500') or as a named HTML color (e.g. 'orange').</summary>
        public string Color { get; set; }
        /// <summary>Constant value that indicates the specific side of the border. Possible values are: EdgeTop, EdgeBottom, EdgeLeft, EdgeRight, InsideVertical, InsideHorizontal, DiagonalDown, DiagonalUp. Read-only.</summary>
        public string SideIndex { get; set; }
        /// <summary>One of the constants of line style specifying the line style for the border. Possible values are: None, Continuous, Dash, DashDot, DashDotDot, Dot, Double, SlantDashDot.</summary>
        public string Style { get; set; }
        /// <summary>Specifies the weight of the border around a range. Possible values are: Hairline, Thin, Medium, Thick.</summary>
        public string Weight { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"color", (o,n) => { (o as WorkbookRangeBorder).Color = n.GetStringValue(); } },
                {"sideIndex", (o,n) => { (o as WorkbookRangeBorder).SideIndex = n.GetStringValue(); } },
                {"style", (o,n) => { (o as WorkbookRangeBorder).Style = n.GetStringValue(); } },
                {"weight", (o,n) => { (o as WorkbookRangeBorder).Weight = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("sideIndex", SideIndex);
            writer.WriteStringValue("style", Style);
            writer.WriteStringValue("weight", Weight);
        }
    }
}
