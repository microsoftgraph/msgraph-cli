using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Print.Printers.Create {
    /// <summary>Provides operations to call the create method.</summary>
    public class CreatePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The certificateSigningRequest property</summary>
        public PrintCertificateSigningRequest CertificateSigningRequest { get; set; }
        /// <summary>The connectorId property</summary>
        public string ConnectorId { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The hasPhysicalDevice property</summary>
        public bool? HasPhysicalDevice { get; set; }
        /// <summary>The manufacturer property</summary>
        public string Manufacturer { get; set; }
        /// <summary>The model property</summary>
        public string Model { get; set; }
        /// <summary>The physicalDeviceId property</summary>
        public string PhysicalDeviceId { get; set; }
        /// <summary>
        /// Instantiates a new createPostRequestBody and sets the default values.
        /// </summary>
        public CreatePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certificateSigningRequest", n => { CertificateSigningRequest = n.GetObjectValue<PrintCertificateSigningRequest>(PrintCertificateSigningRequest.CreateFromDiscriminatorValue); } },
                {"connectorId", n => { ConnectorId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hasPhysicalDevice", n => { HasPhysicalDevice = n.GetBoolValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"physicalDeviceId", n => { PhysicalDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintCertificateSigningRequest>("certificateSigningRequest", CertificateSigningRequest);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("physicalDeviceId", PhysicalDeviceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
