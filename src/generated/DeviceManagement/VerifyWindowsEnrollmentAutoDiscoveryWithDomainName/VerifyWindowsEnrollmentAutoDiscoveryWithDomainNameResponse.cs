using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName {
    public class VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? Value { get; set; }
        /// <summary>
        /// Instantiates a new verifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse and sets the default values.
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
