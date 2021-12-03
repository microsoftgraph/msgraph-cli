using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceManagementExportJob : Entity, IParsable {
        /// <summary>Time that the exported report expires</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Filters applied on the report</summary>
        public string Filter { get; set; }
        /// <summary>Format of the exported report. Possible values are: csv, pdf.</summary>
        public DeviceManagementReportFileFormat? Format { get; set; }
        /// <summary>Configures how the requested export job is localized. Possible values are: localizedValuesAsAdditionalColumn, replaceLocalizableValues.</summary>
        public DeviceManagementExportJobLocalizationType? LocalizationType { get; set; }
        /// <summary>Name of the report</summary>
        public string ReportName { get; set; }
        /// <summary>Time that the exported report was requested</summary>
        public DateTimeOffset? RequestDateTime { get; set; }
        /// <summary>Columns selected from the report</summary>
        public List<string> Select { get; set; }
        /// <summary>A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id.</summary>
        public string SnapshotId { get; set; }
        /// <summary>Status of the export job. Possible values are: unknown, notStarted, inProgress, completed, failed.</summary>
        public DeviceManagementReportStatus? Status { get; set; }
        /// <summary>Temporary location of the exported report</summary>
        public string Url { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"expirationDateTime", (o,n) => { (o as DeviceManagementExportJob).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"filter", (o,n) => { (o as DeviceManagementExportJob).Filter = n.GetStringValue(); } },
                {"format", (o,n) => { (o as DeviceManagementExportJob).Format = n.GetEnumValue<DeviceManagementReportFileFormat>(); } },
                {"localizationType", (o,n) => { (o as DeviceManagementExportJob).LocalizationType = n.GetEnumValue<DeviceManagementExportJobLocalizationType>(); } },
                {"reportName", (o,n) => { (o as DeviceManagementExportJob).ReportName = n.GetStringValue(); } },
                {"requestDateTime", (o,n) => { (o as DeviceManagementExportJob).RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"select", (o,n) => { (o as DeviceManagementExportJob).Select = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"snapshotId", (o,n) => { (o as DeviceManagementExportJob).SnapshotId = n.GetStringValue(); } },
                {"status", (o,n) => { (o as DeviceManagementExportJob).Status = n.GetEnumValue<DeviceManagementReportStatus>(); } },
                {"url", (o,n) => { (o as DeviceManagementExportJob).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("filter", Filter);
            writer.WriteEnumValue<DeviceManagementReportFileFormat>("format", Format);
            writer.WriteEnumValue<DeviceManagementExportJobLocalizationType>("localizationType", LocalizationType);
            writer.WriteStringValue("reportName", ReportName);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteStringValue("snapshotId", SnapshotId);
            writer.WriteEnumValue<DeviceManagementReportStatus>("status", Status);
            writer.WriteStringValue("url", Url);
        }
    }
}
