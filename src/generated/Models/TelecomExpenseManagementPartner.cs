using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>telecomExpenseManagementPartner resources represent the metadata and status of a given TEM service. Once your organization has onboarded with a partner, the partner can be enabled or disabled to switch TEM functionality on or off.</summary>
    public class TelecomExpenseManagementPartner : Entity, IParsable {
        /// <summary>Whether the partner&apos;s AAD app has been authorized to access Intune.</summary>
        public bool? AppAuthorized { get; set; }
        /// <summary>Display name of the TEM partner.</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether Intune&apos;s connection to the TEM service is currently enabled or disabled.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Timestamp of the last request sent to Intune by the TEM partner.</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>URL of the TEM partner&apos;s administrative control panel, where an administrator can configure their TEM service.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Instantiates a new telecomExpenseManagementPartner and sets the default values.
        /// </summary>
        public TelecomExpenseManagementPartner() : base() {
            OdataType = "#microsoft.graph.telecomExpenseManagementPartner";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TelecomExpenseManagementPartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TelecomExpenseManagementPartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appAuthorized", n => { AppAuthorized = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"lastConnectionDateTime", n => { LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appAuthorized", AppAuthorized);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteStringValue("url", Url);
        }
    }
}
