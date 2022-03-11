using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport {
    public class GetPolicyNonComplianceSummaryReportRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Filter { get; set; }
        public List<string> GroupBy { get; set; }
        public string Name { get; set; }
        public List<string> OrderBy { get; set; }
        public string Search { get; set; }
        public List<string> Select { get; set; }
        public string SessionId { get; set; }
        public int? Skip { get; set; }
        public int? Top { get; set; }
        /// <summary>
        /// Instantiates a new getPolicyNonComplianceSummaryReportRequestBody and sets the default values.
        /// </summary>
        public GetPolicyNonComplianceSummaryReportRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetPolicyNonComplianceSummaryReportRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetPolicyNonComplianceSummaryReportRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"filter", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Filter = n.GetStringValue(); } },
                {"groupBy", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).GroupBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Name = n.GetStringValue(); } },
                {"orderBy", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).OrderBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"search", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Search = n.GetStringValue(); } },
                {"select", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Select = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sessionId", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).SessionId = n.GetStringValue(); } },
                {"skip", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Skip = n.GetIntValue(); } },
                {"top", (o,n) => { (o as GetPolicyNonComplianceSummaryReportRequestBody).Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("filter", Filter);
            writer.WriteCollectionOfPrimitiveValues<string>("groupBy", GroupBy);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
