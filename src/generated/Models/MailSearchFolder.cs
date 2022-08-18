using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MailSearchFolder : MailFolder, IParsable {
        /// <summary>The OData query to filter the messages.</summary>
        public string FilterQuery { get; set; }
        /// <summary>Indicates how the mailbox folder hierarchy should be traversed in the search. true means that a deep search should be done to include child folders in the hierarchy of each folder explicitly specified in sourceFolderIds. false means a shallow search of only each of the folders explicitly specified in sourceFolderIds.</summary>
        public bool? IncludeNestedFolders { get; set; }
        /// <summary>Indicates whether a search folder is editable using REST APIs.</summary>
        public bool? IsSupported { get; set; }
        /// <summary>The mailbox folders that should be mined.</summary>
        public List<string> SourceFolderIds { get; set; }
        /// <summary>
        /// Instantiates a new MailSearchFolder and sets the default values.
        /// </summary>
        public MailSearchFolder() : base() {
            OdataType = "#microsoft.graph.mailSearchFolder";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MailSearchFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailSearchFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"filterQuery", n => { FilterQuery = n.GetStringValue(); } },
                {"includeNestedFolders", n => { IncludeNestedFolders = n.GetBoolValue(); } },
                {"isSupported", n => { IsSupported = n.GetBoolValue(); } },
                {"sourceFolderIds", n => { SourceFolderIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("filterQuery", FilterQuery);
            writer.WriteBoolValue("includeNestedFolders", IncludeNestedFolders);
            writer.WriteBoolValue("isSupported", IsSupported);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceFolderIds", SourceFolderIds);
        }
    }
}
