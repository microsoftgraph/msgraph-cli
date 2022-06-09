using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class PrintConnector : Entity, IParsable {
        /// <summary>The connector&apos;s version.</summary>
        public string AppVersion { get; set; }
        /// <summary>The name of the connector.</summary>
        public string DisplayName { get; set; }
        /// <summary>The connector machine&apos;s hostname.</summary>
        public string FullyQualifiedDomainName { get; set; }
        /// <summary>The physical and/or organizational location of the connector.</summary>
        public PrinterLocation Location { get; set; }
        /// <summary>The connector machine&apos;s operating system version.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>The DateTimeOffset when the connector was registered.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fullyQualifiedDomainName", n => { FullyQualifiedDomainName = n.GetStringValue(); } },
                {"location", n => { Location = n.GetObjectValue<PrinterLocation>(PrinterLocation.CreateFromDiscriminatorValue); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fullyQualifiedDomainName", FullyQualifiedDomainName);
            writer.WriteObjectValue<PrinterLocation>("location", Location);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
        }
    }
}
