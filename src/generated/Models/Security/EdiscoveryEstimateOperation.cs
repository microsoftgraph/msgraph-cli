using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Security {
    public class EdiscoveryEstimateOperation : CaseOperation, IParsable {
        /// <summary>The estimated count of items for the search that matched the content query.</summary>
        public long? IndexedItemCount { get; set; }
        /// <summary>The estimated size of items for the search that matched the content query.</summary>
        public long? IndexedItemsSize { get; set; }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? MailboxCount { get; set; }
        /// <summary>eDiscovery search.</summary>
        public EdiscoverySearch Search { get; set; }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? SiteCount { get; set; }
        /// <summary>The estimated count of unindexed items for the collection.</summary>
        public long? UnindexedItemCount { get; set; }
        /// <summary>The estimated size of unindexed items for the collection.</summary>
        public long? UnindexedItemsSize { get; set; }
        /// <summary>
        /// Instantiates a new ediscoveryEstimateOperation and sets the default values.
        /// </summary>
        public EdiscoveryEstimateOperation() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryEstimateOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryEstimateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryEstimateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"indexedItemCount", n => { IndexedItemCount = n.GetLongValue(); } },
                {"indexedItemsSize", n => { IndexedItemsSize = n.GetLongValue(); } },
                {"mailboxCount", n => { MailboxCount = n.GetIntValue(); } },
                {"search", n => { Search = n.GetObjectValue<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue); } },
                {"siteCount", n => { SiteCount = n.GetIntValue(); } },
                {"unindexedItemCount", n => { UnindexedItemCount = n.GetLongValue(); } },
                {"unindexedItemsSize", n => { UnindexedItemsSize = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("indexedItemCount", IndexedItemCount);
            writer.WriteLongValue("indexedItemsSize", IndexedItemsSize);
            writer.WriteIntValue("mailboxCount", MailboxCount);
            writer.WriteObjectValue<EdiscoverySearch>("search", Search);
            writer.WriteIntValue("siteCount", SiteCount);
            writer.WriteLongValue("unindexedItemCount", UnindexedItemCount);
            writer.WriteLongValue("unindexedItemsSize", UnindexedItemsSize);
        }
    }
}
