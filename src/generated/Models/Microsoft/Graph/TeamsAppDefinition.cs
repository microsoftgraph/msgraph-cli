using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamsAppDefinition : Entity, IParsable {
        /// <summary>The details of the bot specified in the Teams app manifest.</summary>
        public TeamworkBot Bot { get; set; }
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Verbose description of the application.</summary>
        public string Description { get; set; }
        /// <summary>The name of the app provided by the app developer.</summary>
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The published status of a specific version of a Teams app. Possible values are:submitted — The specific version of the Teams app has been submitted and is under review. published  — The request to publish the specific version of the Teams app has been approved by the admin and the app is published.  rejected — The request to publish the specific version of the Teams app was rejected by the admin.</summary>
        public TeamsAppPublishingState? PublishingState { get; set; }
        /// <summary>Short description of the application.</summary>
        public string ShortDescription { get; set; }
        /// <summary>The ID from the Teams app manifest.</summary>
        public string TeamsAppId { get; set; }
        /// <summary>The version number of the application.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bot", (o,n) => { (o as TeamsAppDefinition).Bot = n.GetObjectValue<TeamworkBot>(); } },
                {"createdBy", (o,n) => { (o as TeamsAppDefinition).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"description", (o,n) => { (o as TeamsAppDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TeamsAppDefinition).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TeamsAppDefinition).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publishingState", (o,n) => { (o as TeamsAppDefinition).PublishingState = n.GetEnumValue<TeamsAppPublishingState>(); } },
                {"shortDescription", (o,n) => { (o as TeamsAppDefinition).ShortDescription = n.GetStringValue(); } },
                {"teamsAppId", (o,n) => { (o as TeamsAppDefinition).TeamsAppId = n.GetStringValue(); } },
                {"version", (o,n) => { (o as TeamsAppDefinition).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkBot>("bot", Bot);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<TeamsAppPublishingState>("publishingState", PublishingState);
            writer.WriteStringValue("shortDescription", ShortDescription);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteStringValue("version", Version);
        }
    }
}
