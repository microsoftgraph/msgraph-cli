using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.AssignLicense {
    public class AssignLicenseRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<AssignedLicense> AddLicenses { get; set; }
        public List<string> RemoveLicenses { get; set; }
        /// <summary>
        /// Instantiates a new assignLicenseRequestBody and sets the default values.
        /// </summary>
        public AssignLicenseRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addLicenses", (o,n) => { (o as AssignLicenseRequestBody).AddLicenses = n.GetCollectionOfObjectValues<AssignedLicense>().ToList(); } },
                {"removeLicenses", (o,n) => { (o as AssignLicenseRequestBody).RemoveLicenses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AssignedLicense>("addLicenses", AddLicenses);
            writer.WriteCollectionOfPrimitiveValues<string>("removeLicenses", RemoveLicenses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
