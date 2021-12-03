using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Teams.Item.Clone {
    public class CloneRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string MailNickname { get; set; }
        public ClonableTeamParts? PartsToClone { get; set; }
        public TeamVisibilityType? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new cloneRequestBody and sets the default values.
        /// </summary>
        public CloneRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classification", (o,n) => { (o as CloneRequestBody).Classification = n.GetStringValue(); } },
                {"description", (o,n) => { (o as CloneRequestBody).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloneRequestBody).DisplayName = n.GetStringValue(); } },
                {"mailNickname", (o,n) => { (o as CloneRequestBody).MailNickname = n.GetStringValue(); } },
                {"partsToClone", (o,n) => { (o as CloneRequestBody).PartsToClone = n.GetEnumValue<ClonableTeamParts>(); } },
                {"visibility", (o,n) => { (o as CloneRequestBody).Visibility = n.GetEnumValue<TeamVisibilityType>(); } },
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
