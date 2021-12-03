using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SharingInvitation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address provided for the recipient of the sharing invitation. Read-only.</summary>
        public string Email { get; set; }
        /// <summary>Provides information about who sent the invitation that created this permission, if that information is available. Read-only.</summary>
        public IdentitySet InvitedBy { get; set; }
        public string RedeemedBy { get; set; }
        /// <summary>If true the recipient of the invitation needs to sign in in order to access the shared item. Read-only.</summary>
        public bool? SignInRequired { get; set; }
        /// <summary>
        /// Instantiates a new sharingInvitation and sets the default values.
        /// </summary>
        public SharingInvitation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"email", (o,n) => { (o as SharingInvitation).Email = n.GetStringValue(); } },
                {"invitedBy", (o,n) => { (o as SharingInvitation).InvitedBy = n.GetObjectValue<IdentitySet>(); } },
                {"redeemedBy", (o,n) => { (o as SharingInvitation).RedeemedBy = n.GetStringValue(); } },
                {"signInRequired", (o,n) => { (o as SharingInvitation).SignInRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<IdentitySet>("invitedBy", InvitedBy);
            writer.WriteStringValue("redeemedBy", RedeemedBy);
            writer.WriteBoolValue("signInRequired", SignInRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
