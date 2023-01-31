using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharingInvitation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address provided for the recipient of the sharing invitation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Provides information about who sent the invitation that created this permission, if that information is available. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? InvitedBy { get; set; }
#nullable restore
#else
        public IdentitySet InvitedBy { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedeemedBy { get; set; }
#nullable restore
#else
        public string RedeemedBy { get; set; }
#endif
        /// <summary>If true the recipient of the invitation needs to sign in in order to access the shared item. Read-only.</summary>
        public bool? SignInRequired { get; set; }
        /// <summary>
        /// Instantiates a new sharingInvitation and sets the default values.
        /// </summary>
        public SharingInvitation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static SharingInvitation CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static SharingInvitation CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharingInvitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email", n => { Email = n.GetStringValue(); } },
                {"invitedBy", n => { InvitedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"redeemedBy", n => { RedeemedBy = n.GetStringValue(); } },
                {"signInRequired", n => { SignInRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<IdentitySet>("invitedBy", InvitedBy);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("redeemedBy", RedeemedBy);
            writer.WriteBoolValue("signInRequired", SignInRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
