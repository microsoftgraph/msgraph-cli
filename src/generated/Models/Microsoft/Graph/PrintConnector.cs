using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintConnector : Entity, IParsable {
        /// <summary>The connector's version.</summary>
        public string AppVersion { get; set; }
        /// <summary>The name of the connector.</summary>
        public string DisplayName { get; set; }
        /// <summary>The connector machine's hostname.</summary>
        public string FullyQualifiedDomainName { get; set; }
        /// <summary>The physical and/or organizational location of the connector.</summary>
        public PrinterLocation Location { get; set; }
        /// <summary>The connector machine's operating system version.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>The DateTimeOffset when the connector was registered.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appVersion", (o,n) => { (o as PrintConnector).AppVersion = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PrintConnector).DisplayName = n.GetStringValue(); } },
                {"fullyQualifiedDomainName", (o,n) => { (o as PrintConnector).FullyQualifiedDomainName = n.GetStringValue(); } },
                {"location", (o,n) => { (o as PrintConnector).Location = n.GetObjectValue<PrinterLocation>(); } },
                {"operatingSystem", (o,n) => { (o as PrintConnector).OperatingSystem = n.GetStringValue(); } },
                {"registeredDateTime", (o,n) => { (o as PrintConnector).RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
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
