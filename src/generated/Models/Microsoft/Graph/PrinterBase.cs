using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrinterBase : Entity, IParsable {
        /// <summary>The capabilities of the printer/printerShare.</summary>
        public ApiSdk.Models.Microsoft.Graph.PrinterCapabilities Capabilities { get; set; }
        /// <summary>The default print settings of printer/printerShare.</summary>
        public ApiSdk.Models.Microsoft.Graph.PrinterDefaults Defaults { get; set; }
        /// <summary>The name of the printer/printerShare.</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether the printer/printerShare is currently accepting new print jobs.</summary>
        public bool? IsAcceptingJobs { get; set; }
        /// <summary>The list of jobs that are queued for printing by the printer/printerShare.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintJob> Jobs { get; set; }
        /// <summary>The physical and/or organizational location of the printer/printerShare.</summary>
        public ApiSdk.Models.Microsoft.Graph.PrinterLocation Location { get; set; }
        /// <summary>The manufacturer of the printer/printerShare.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The model name of the printer/printerShare.</summary>
        public string Model { get; set; }
        public ApiSdk.Models.Microsoft.Graph.PrinterStatus Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PrinterBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"capabilities", (o,n) => { (o as PrinterBase).Capabilities = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterCapabilities>(ApiSdk.Models.Microsoft.Graph.PrinterCapabilities.CreateFromDiscriminatorValue); } },
                {"defaults", (o,n) => { (o as PrinterBase).Defaults = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterDefaults>(ApiSdk.Models.Microsoft.Graph.PrinterDefaults.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as PrinterBase).DisplayName = n.GetStringValue(); } },
                {"isAcceptingJobs", (o,n) => { (o as PrinterBase).IsAcceptingJobs = n.GetBoolValue(); } },
                {"jobs", (o,n) => { (o as PrinterBase).Jobs = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintJob>(ApiSdk.Models.Microsoft.Graph.PrintJob.CreateFromDiscriminatorValue).ToList(); } },
                {"location", (o,n) => { (o as PrinterBase).Location = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterLocation>(ApiSdk.Models.Microsoft.Graph.PrinterLocation.CreateFromDiscriminatorValue); } },
                {"manufacturer", (o,n) => { (o as PrinterBase).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as PrinterBase).Model = n.GetStringValue(); } },
                {"status", (o,n) => { (o as PrinterBase).Status = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterStatus>(ApiSdk.Models.Microsoft.Graph.PrinterStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterCapabilities>("capabilities", Capabilities);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterDefaults>("defaults", Defaults);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAcceptingJobs", IsAcceptingJobs);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintJob>("jobs", Jobs);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterLocation>("location", Location);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PrinterStatus>("status", Status);
        }
    }
}
