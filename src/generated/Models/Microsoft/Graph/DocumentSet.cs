using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DocumentSet : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Content types allowed in document set.</summary>
        public List<ContentTypeInfo> AllowedContentTypes { get; set; }
        /// <summary>Default contents of document set.</summary>
        public List<DocumentSetContent> DefaultContents { get; set; }
        /// <summary>Specifies whether to push welcome page changes to inherited content types.</summary>
        public bool? PropagateWelcomePageChanges { get; set; }
        public List<ColumnDefinition> SharedColumns { get; set; }
        /// <summary>Add the name of the Document Set to each file name.</summary>
        public bool? ShouldPrefixNameToFile { get; set; }
        public List<ColumnDefinition> WelcomePageColumns { get; set; }
        /// <summary>Welcome page absolute URL.</summary>
        public string WelcomePageUrl { get; set; }
        /// <summary>
        /// Instantiates a new documentSet and sets the default values.
        /// </summary>
        public DocumentSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedContentTypes", (o,n) => { (o as DocumentSet).AllowedContentTypes = n.GetCollectionOfObjectValues<ContentTypeInfo>().ToList(); } },
                {"defaultContents", (o,n) => { (o as DocumentSet).DefaultContents = n.GetCollectionOfObjectValues<DocumentSetContent>().ToList(); } },
                {"propagateWelcomePageChanges", (o,n) => { (o as DocumentSet).PropagateWelcomePageChanges = n.GetBoolValue(); } },
                {"sharedColumns", (o,n) => { (o as DocumentSet).SharedColumns = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"shouldPrefixNameToFile", (o,n) => { (o as DocumentSet).ShouldPrefixNameToFile = n.GetBoolValue(); } },
                {"welcomePageColumns", (o,n) => { (o as DocumentSet).WelcomePageColumns = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"welcomePageUrl", (o,n) => { (o as DocumentSet).WelcomePageUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ContentTypeInfo>("allowedContentTypes", AllowedContentTypes);
            writer.WriteCollectionOfObjectValues<DocumentSetContent>("defaultContents", DefaultContents);
            writer.WriteBoolValue("propagateWelcomePageChanges", PropagateWelcomePageChanges);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("sharedColumns", SharedColumns);
            writer.WriteBoolValue("shouldPrefixNameToFile", ShouldPrefixNameToFile);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("welcomePageColumns", WelcomePageColumns);
            writer.WriteStringValue("welcomePageUrl", WelcomePageUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
