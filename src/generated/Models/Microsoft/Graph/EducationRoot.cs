using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationRoot : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.EducationClass> Classes { get; set; }
        public ApiSdk.Models.Microsoft.Graph.EducationUser Me { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.EducationSchool> Schools { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.EducationUser> Users { get; set; }
        /// <summary>
        /// Instantiates a new EducationRoot and sets the default values.
        /// </summary>
        public EducationRoot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.EducationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classes", (o,n) => { (o as EducationRoot).Classes = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationClass>(ApiSdk.Models.Microsoft.Graph.EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"me", (o,n) => { (o as EducationRoot).Me = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EducationUser>(ApiSdk.Models.Microsoft.Graph.EducationUser.CreateFromDiscriminatorValue); } },
                {"schools", (o,n) => { (o as EducationRoot).Schools = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationSchool>(ApiSdk.Models.Microsoft.Graph.EducationSchool.CreateFromDiscriminatorValue).ToList(); } },
                {"users", (o,n) => { (o as EducationRoot).Users = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationUser>(ApiSdk.Models.Microsoft.Graph.EducationUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationClass>("classes", Classes);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EducationUser>("me", Me);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
