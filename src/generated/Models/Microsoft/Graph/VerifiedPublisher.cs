using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class VerifiedPublisher : IAdditionalDataHolder, IParsable {
        /// <summary>The timestamp when the verified publisher was first added or most recently updated.</summary>
        public DateTimeOffset? AddedDateTime { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The verified publisher name from the app publisher's Partner Center account.</summary>
        public string DisplayName { get; set; }
        /// <summary>The ID of the verified publisher from the app publisher's Partner Center account.</summary>
        public string VerifiedPublisherId { get; set; }
        /// <summary>
        /// Instantiates a new verifiedPublisher and sets the default values.
        /// </summary>
        public VerifiedPublisher() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.VerifiedPublisher CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiedPublisher();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addedDateTime", (o,n) => { (o as VerifiedPublisher).AddedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as VerifiedPublisher).DisplayName = n.GetStringValue(); } },
                {"verifiedPublisherId", (o,n) => { (o as VerifiedPublisher).VerifiedPublisherId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("addedDateTime", AddedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("verifiedPublisherId", VerifiedPublisherId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
