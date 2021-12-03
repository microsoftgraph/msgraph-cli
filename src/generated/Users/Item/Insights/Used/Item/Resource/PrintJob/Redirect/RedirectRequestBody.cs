using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Insights.Used.Item.Resource.PrintJob.Redirect {
    public class RedirectRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public PrintJobConfiguration Configuration { get; set; }
        public string DestinationPrinterId { get; set; }
        /// <summary>
        /// Instantiates a new redirectRequestBody and sets the default values.
        /// </summary>
        public RedirectRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configuration", (o,n) => { (o as RedirectRequestBody).Configuration = n.GetObjectValue<PrintJobConfiguration>(); } },
                {"destinationPrinterId", (o,n) => { (o as RedirectRequestBody).DestinationPrinterId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintJobConfiguration>("configuration", Configuration);
            writer.WriteStringValue("destinationPrinterId", DestinationPrinterId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
