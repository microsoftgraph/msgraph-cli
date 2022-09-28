using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.AssignLicense {
    /// <summary>Provides operations to call the assignLicense method.</summary>
    public class AssignLicensePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The addLicenses property</summary>
        public List<AssignedLicense> AddLicenses { get; set; }
        /// <summary>The removeLicenses property</summary>
        public List<string> RemoveLicenses { get; set; }
        /// <summary>
        /// Instantiates a new assignLicensePostRequestBody and sets the default values.
        /// </summary>
        public AssignLicensePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignLicensePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignLicensePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addLicenses", n => { AddLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"removeLicenses", n => { RemoveLicenses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
