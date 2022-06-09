using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.Team.Clone {
    /// <summary>Provides operations to call the clone method.</summary>
    public class ClonePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classification property</summary>
        public string Classification { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The mailNickname property</summary>
        public string MailNickname { get; set; }
        /// <summary>The partsToClone property</summary>
        public ClonableTeamParts? PartsToClone { get; set; }
        /// <summary>The visibility property</summary>
        public TeamVisibilityType? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new clonePostRequestBody and sets the default values.
        /// </summary>
        public ClonePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClonePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClonePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"classification", n => { Classification = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"partsToClone", n => { PartsToClone = n.GetEnumValue<ClonableTeamParts>(); } },
                {"visibility", n => { Visibility = n.GetEnumValue<TeamVisibilityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("classification", Classification);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteEnumValue<ClonableTeamParts>("partsToClone", PartsToClone);
            writer.WriteEnumValue<TeamVisibilityType>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
