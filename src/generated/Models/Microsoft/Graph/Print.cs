using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Print : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of available print connectors.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintConnector> Connectors { get; set; }
        /// <summary>The list of print long running operations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintOperation> Operations { get; set; }
        /// <summary>The list of printers registered in the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Printer> Printers { get; set; }
        /// <summary>The list of available Universal Print service endpoints.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintService> Services { get; set; }
        /// <summary>Tenant-wide settings for the Universal Print service.</summary>
        public ApiSdk.Models.Microsoft.Graph.PrintSettings Settings { get; set; }
        /// <summary>The list of printer shares registered in the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrinterShare> Shares { get; set; }
        /// <summary>List of abstract definition for a task that can be triggered when various events occur within Universal Print.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintTaskDefinition> TaskDefinitions { get; set; }
        /// <summary>
        /// Instantiates a new Print and sets the default values.
        /// </summary>
        public Print() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.Print CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Print();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"connectors", (o,n) => { (o as Print).Connectors = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintConnector>(ApiSdk.Models.Microsoft.Graph.PrintConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", (o,n) => { (o as Print).Operations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintOperation>(ApiSdk.Models.Microsoft.Graph.PrintOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"printers", (o,n) => { (o as Print).Printers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Printer>(ApiSdk.Models.Microsoft.Graph.Printer.CreateFromDiscriminatorValue).ToList(); } },
                {"services", (o,n) => { (o as Print).Services = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintService>(ApiSdk.Models.Microsoft.Graph.PrintService.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as Print).Settings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PrintSettings>(ApiSdk.Models.Microsoft.Graph.PrintSettings.CreateFromDiscriminatorValue); } },
                {"shares", (o,n) => { (o as Print).Shares = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrinterShare>(ApiSdk.Models.Microsoft.Graph.PrinterShare.CreateFromDiscriminatorValue).ToList(); } },
                {"taskDefinitions", (o,n) => { (o as Print).TaskDefinitions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintTaskDefinition>(ApiSdk.Models.Microsoft.Graph.PrintTaskDefinition.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintConnector>("connectors", Connectors);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Printer>("printers", Printers);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintService>("services", Services);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PrintSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintTaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
