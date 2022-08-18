using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationSchool : EducationOrganization, IParsable {
        /// <summary>Address of the school.</summary>
        public PhysicalAddress Address { get; set; }
        /// <summary>The underlying administrativeUnit for this school.</summary>
        public ApiSdk.Models.AdministrativeUnit AdministrativeUnit { get; set; }
        /// <summary>Classes taught at the school. Nullable.</summary>
        public List<EducationClass> Classes { get; set; }
        /// <summary>Entity who created the school.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>ID of school in syncing system.</summary>
        public string ExternalId { get; set; }
        /// <summary>ID of principal in syncing system.</summary>
        public string ExternalPrincipalId { get; set; }
        /// <summary>The fax property</summary>
        public string Fax { get; set; }
        /// <summary>Highest grade taught.</summary>
        public string HighestGrade { get; set; }
        /// <summary>Lowest grade taught.</summary>
        public string LowestGrade { get; set; }
        /// <summary>Phone number of school.</summary>
        public string Phone { get; set; }
        /// <summary>Email address of the principal.</summary>
        public string PrincipalEmail { get; set; }
        /// <summary>Name of the principal.</summary>
        public string PrincipalName { get; set; }
        /// <summary>School Number.</summary>
        public string SchoolNumber { get; set; }
        /// <summary>Users in the school. Nullable.</summary>
        public List<EducationUser> Users { get; set; }
        /// <summary>
        /// Instantiates a new EducationSchool and sets the default values.
        /// </summary>
        public EducationSchool() : base() {
            OdataType = "#microsoft.graph.educationSchool";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSchool CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSchool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"administrativeUnit", n => { AdministrativeUnit = n.GetObjectValue<ApiSdk.Models.AdministrativeUnit>(ApiSdk.Models.AdministrativeUnit.CreateFromDiscriminatorValue); } },
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"externalPrincipalId", n => { ExternalPrincipalId = n.GetStringValue(); } },
                {"fax", n => { Fax = n.GetStringValue(); } },
                {"highestGrade", n => { HighestGrade = n.GetStringValue(); } },
                {"lowestGrade", n => { LowestGrade = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"principalEmail", n => { PrincipalEmail = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"schoolNumber", n => { SchoolNumber = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<ApiSdk.Models.AdministrativeUnit>("administrativeUnit", AdministrativeUnit);
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalPrincipalId", ExternalPrincipalId);
            writer.WriteStringValue("fax", Fax);
            writer.WriteStringValue("highestGrade", HighestGrade);
            writer.WriteStringValue("lowestGrade", LowestGrade);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("principalEmail", PrincipalEmail);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("schoolNumber", SchoolNumber);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
        }
    }
}
