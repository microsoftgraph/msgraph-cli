using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewSet : Entity, IParsable {
        /// <summary>Represents the template and scheduling for an access review.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessReviewScheduleDefinition> Definitions { get; set; }
        /// <summary>Represents a collection of access review history data and the scopes used to collect that data.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryDefinition> HistoryDefinitions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessReviewSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"definitions", (o,n) => { (o as AccessReviewSet).Definitions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewScheduleDefinition>(ApiSdk.Models.Microsoft.Graph.AccessReviewScheduleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"historyDefinitions", (o,n) => { (o as AccessReviewSet).HistoryDefinitions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryDefinition>(ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryDefinition.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewScheduleDefinition>("definitions", Definitions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryDefinition>("historyDefinitions", HistoryDefinitions);
        }
    }
}
