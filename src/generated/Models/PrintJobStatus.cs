using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PrintJobStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the print job&apos;s current processing state. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Additional details for print job state. Valid values are described in the following table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintJobStateDetail?>? Details { get; set; }
#nullable restore
#else
        public List<PrintJobStateDetail?> Details { get; set; }
#endif
        /// <summary>True if the job was acknowledged by a printer; false otherwise. Read-only.</summary>
        public bool? IsAcquiredByPrinter { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        public PrintJobProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printJobStatus and sets the default values.
        /// </summary>
        public PrintJobStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static PrintJobStatus CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static PrintJobStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintJobStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfEnumValues<PrintJobStateDetail>()?.ToList(); } },
                {"isAcquiredByPrinter", n => { IsAcquiredByPrinter = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<PrintJobProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfEnumValues<PrintJobStateDetail>("details", Details);
            writer.WriteBoolValue("isAcquiredByPrinter", IsAcquiredByPrinter);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PrintJobProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
