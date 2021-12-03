using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Education : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<EducationClass> Classes { get; set; }
        public EducationUser Me { get; set; }
        public List<EducationSchool> Schools { get; set; }
        public List<EducationUser> Users { get; set; }
        /// <summary>
        /// Instantiates a new education and sets the default values.
        /// </summary>
        public Education() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classes", (o,n) => { (o as Education).Classes = n.GetCollectionOfObjectValues<EducationClass>().ToList(); } },
                {"me", (o,n) => { (o as Education).Me = n.GetObjectValue<EducationUser>(); } },
                {"schools", (o,n) => { (o as Education).Schools = n.GetCollectionOfObjectValues<EducationSchool>().ToList(); } },
                {"users", (o,n) => { (o as Education).Users = n.GetCollectionOfObjectValues<EducationUser>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<EducationUser>("me", Me);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
