using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.TermStore {
    public class Store : Entity, IParsable {
        /// <summary>Default language of the term store.</summary>
        public string DefaultLanguageTag { get; set; }
        /// <summary>Collection of all groups available in the term store.</summary>
        public List<Group> Groups { get; set; }
        /// <summary>List of languages for the term store.</summary>
        public List<string> LanguageTags { get; set; }
        /// <summary>Collection of all sets available in the term store.</summary>
        public List<Set> Sets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Store CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Store();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"defaultLanguageTag", (o,n) => { (o as Store).DefaultLanguageTag = n.GetStringValue(); } },
                {"groups", (o,n) => { (o as Store).Groups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue).ToList(); } },
                {"languageTags", (o,n) => { (o as Store).LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sets", (o,n) => { (o as Store).Sets = n.GetCollectionOfObjectValues<Set>(Set.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultLanguageTag", DefaultLanguageTag);
            writer.WriteCollectionOfObjectValues<Group>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfObjectValues<Set>("sets", Sets);
        }
    }
}
