using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IntuneBrand : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
        public string ContactITEmailAddress { get; set; }
        /// <summary>Name of the person/organization responsible for IT support.</summary>
        public string ContactITName { get; set; }
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
        public string ContactITNotes { get; set; }
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
        public string ContactITPhoneNumber { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
        public MimeContent DarkBackgroundLogo { get; set; }
        /// <summary>Company/organization name that is displayed to end users.</summary>
        public string DisplayName { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
        public MimeContent LightBackgroundLogo { get; set; }
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteName { get; set; }
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteUrl { get; set; }
        /// <summary>URL to the company/organization’s privacy policy.</summary>
        public string PrivacyUrl { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo { get; set; }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
        public RgbColor ThemeColor { get; set; }
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contactITEmailAddress", (o,n) => { (o as IntuneBrand).ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", (o,n) => { (o as IntuneBrand).ContactITName = n.GetStringValue(); } },
                {"contactITNotes", (o,n) => { (o as IntuneBrand).ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", (o,n) => { (o as IntuneBrand).ContactITPhoneNumber = n.GetStringValue(); } },
                {"darkBackgroundLogo", (o,n) => { (o as IntuneBrand).DarkBackgroundLogo = n.GetObjectValue<MimeContent>(); } },
                {"displayName", (o,n) => { (o as IntuneBrand).DisplayName = n.GetStringValue(); } },
                {"lightBackgroundLogo", (o,n) => { (o as IntuneBrand).LightBackgroundLogo = n.GetObjectValue<MimeContent>(); } },
                {"onlineSupportSiteName", (o,n) => { (o as IntuneBrand).OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", (o,n) => { (o as IntuneBrand).OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", (o,n) => { (o as IntuneBrand).PrivacyUrl = n.GetStringValue(); } },
                {"showDisplayNameNextToLogo", (o,n) => { (o as IntuneBrand).ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", (o,n) => { (o as IntuneBrand).ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", (o,n) => { (o as IntuneBrand).ShowNameNextToLogo = n.GetBoolValue(); } },
                {"themeColor", (o,n) => { (o as IntuneBrand).ThemeColor = n.GetObjectValue<RgbColor>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
