using ApiSdk.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class StandardTimeZoneOffset : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the nth occurrence of the day of week that the transition from daylight saving time to standard time occurs.</summary>
        public int? DayOccurrence { get; set; }
        /// <summary>Represents the day of the week when the transition from daylight saving time to standard time.</summary>
        public ApiSdk.Models.DayOfWeek? DayOfWeek { get; set; }
        /// <summary>Represents the month of the year when the transition from daylight saving time to standard time occurs.</summary>
        public int? Month { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Represents the time of day when the transition from daylight saving time to standard time occurs.</summary>
        public Time? Time { get; set; }
        /// <summary>Represents how frequently in terms of years the change from daylight saving time to standard time occurs. For example, a value of 0 means every year.</summary>
        public int? Year { get; set; }
        /// <summary>
        /// Instantiates a new standardTimeZoneOffset and sets the default values.
        /// </summary>
        public StandardTimeZoneOffset() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.standardTimeZoneOffset";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static StandardTimeZoneOffset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.daylightTimeZoneOffset" => new DaylightTimeZoneOffset(),
                _ => new StandardTimeZoneOffset(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dayOccurrence", n => { DayOccurrence = n.GetIntValue(); } },
                {"dayOfWeek", n => { DayOfWeek = n.GetEnumValue<DayOfWeek>(); } },
                {"month", n => { Month = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"time", n => { Time = n.GetTimeValue(); } },
                {"year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayOccurrence", DayOccurrence);
            writer.WriteEnumValue<DayOfWeek>("dayOfWeek", DayOfWeek);
            writer.WriteIntValue("month", Month);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeValue("time", Time);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
