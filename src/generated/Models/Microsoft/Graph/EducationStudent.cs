using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationStudent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Birth date of the student.</summary>
        public string BirthDate { get; set; }
        /// <summary>ID of the student in the source system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Possible values are: female, male, other.</summary>
        public EducationGender? Gender { get; set; }
        /// <summary>Current grade level of the student.</summary>
        public string Grade { get; set; }
        /// <summary>Year the student is graduating from the school.</summary>
        public string GraduationYear { get; set; }
        /// <summary>Student Number.</summary>
        public string StudentNumber { get; set; }
        /// <summary>
        /// Instantiates a new educationStudent and sets the default values.
        /// </summary>
        public EducationStudent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"birthDate", (o,n) => { (o as EducationStudent).BirthDate = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as EducationStudent).ExternalId = n.GetStringValue(); } },
                {"gender", (o,n) => { (o as EducationStudent).Gender = n.GetEnumValue<EducationGender>(); } },
                {"grade", (o,n) => { (o as EducationStudent).Grade = n.GetStringValue(); } },
                {"graduationYear", (o,n) => { (o as EducationStudent).GraduationYear = n.GetStringValue(); } },
                {"studentNumber", (o,n) => { (o as EducationStudent).StudentNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("birthDate", BirthDate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteEnumValue<EducationGender>("gender", Gender);
            writer.WriteStringValue("grade", Grade);
            writer.WriteStringValue("graduationYear", GraduationYear);
            writer.WriteStringValue("studentNumber", StudentNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
