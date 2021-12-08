using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationCourse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier for the course.</summary>
        public string CourseNumber { get; set; }
        /// <summary>Description of the course.</summary>
        public string Description { get; set; }
        /// <summary>Name of the course.</summary>
        public string DisplayName { get; set; }
        /// <summary>ID of the course from the syncing system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Subject of the course.</summary>
        public string Subject { get; set; }
        /// <summary>
        /// Instantiates a new educationCourse and sets the default values.
        /// </summary>
        public EducationCourse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"courseNumber", (o,n) => { (o as EducationCourse).CourseNumber = n.GetStringValue(); } },
                {"description", (o,n) => { (o as EducationCourse).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as EducationCourse).DisplayName = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as EducationCourse).ExternalId = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as EducationCourse).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("courseNumber", CourseNumber);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
