using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ShiftItem : ScheduleEntity, IParsable {
        /// <summary>An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.</summary>
        public List<ShiftActivity> Activities { get; set; }
        /// <summary>The shift label of the shiftItem.</summary>
        public string DisplayName { get; set; }
        /// <summary>The shift notes for the shiftItem.</summary>
        public string Notes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ShiftItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShiftItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activities", (o,n) => { (o as ShiftItem).Activities = n.GetCollectionOfObjectValues<ShiftActivity>(ShiftActivity.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as ShiftItem).DisplayName = n.GetStringValue(); } },
                {"notes", (o,n) => { (o as ShiftItem).Notes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ShiftActivity>("activities", Activities);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("notes", Notes);
        }
    }
}
