using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ParentalControlSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.</summary>
        public List<string> CountriesBlockedForMinors { get; set; }
        /// <summary>Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.</summary>
        public string LegalAgeGroupRule { get; set; }
        /// <summary>
        /// Instantiates a new parentalControlSettings and sets the default values.
        /// </summary>
        public ParentalControlSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"countriesBlockedForMinors", (o,n) => { (o as ParentalControlSettings).CountriesBlockedForMinors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"legalAgeGroupRule", (o,n) => { (o as ParentalControlSettings).LegalAgeGroupRule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("countriesBlockedForMinors", CountriesBlockedForMinors);
            writer.WriteStringValue("legalAgeGroupRule", LegalAgeGroupRule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
