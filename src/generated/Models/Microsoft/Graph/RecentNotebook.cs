using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecentNotebook : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the notebook.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastAccessedTime { get; set; }
        /// <summary>Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote client, if it's installed. The oneNoteWebURL link opens the notebook in OneNote on the web.</summary>
        public ApiSdk.Models.Microsoft.Graph.RecentNotebookLinks Links { get; set; }
        /// <summary>The backend store where the Notebook resides, either OneDriveForBusiness or OneDrive.</summary>
        public OnenoteSourceService? SourceService { get; set; }
        /// <summary>
        /// Instantiates a new recentNotebook and sets the default values.
        /// </summary>
        public RecentNotebook() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.RecentNotebook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecentNotebook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as RecentNotebook).DisplayName = n.GetStringValue(); } },
                {"lastAccessedTime", (o,n) => { (o as RecentNotebook).LastAccessedTime = n.GetDateTimeOffsetValue(); } },
                {"links", (o,n) => { (o as RecentNotebook).Links = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RecentNotebookLinks>(ApiSdk.Models.Microsoft.Graph.RecentNotebookLinks.CreateFromDiscriminatorValue); } },
                {"sourceService", (o,n) => { (o as RecentNotebook).SourceService = n.GetEnumValue<OnenoteSourceService>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastAccessedTime", LastAccessedTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RecentNotebookLinks>("links", Links);
            writer.WriteEnumValue<OnenoteSourceService>("sourceService", SourceService);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
