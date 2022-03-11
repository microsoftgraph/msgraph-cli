using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationUser : Entity, IParsable {
        /// <summary>True if the account is enabled; otherwise, false. This property is required when a user is created. Supports /$filter.</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>The licenses that are assigned to the user. Not nullable.</summary>
        public List<AssignedLicense> AssignedLicenses { get; set; }
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable.</summary>
        public List<AssignedPlan> AssignedPlans { get; set; }
        /// <summary>List of assignments for the user. Nullable.</summary>
        public List<EducationAssignment> Assignments { get; set; }
        /// <summary>The telephone numbers for the user. Note: Although this is a string collection, only one number can be set for this property.</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>Classes to which the user belongs. Nullable.</summary>
        public List<EducationClass> Classes { get; set; }
        /// <summary>Entity who created the user.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The name for the department in which the user works. Supports /$filter.</summary>
        public string Department { get; set; }
        /// <summary>The name displayed in the address book for the user. Supports $filter and $orderby.</summary>
        public string DisplayName { get; set; }
        /// <summary>The type of external source this resource was generated from (automatically determined from externalSourceDetail). Possible values are: sis, lms, or manual.</summary>
        public EducationExternalSource? ExternalSource { get; set; }
        /// <summary>The name of the external source this resources was generated from.</summary>
        public string ExternalSourceDetail { get; set; }
        /// <summary>The given name (first name) of the user. Supports /$filter.</summary>
        public string GivenName { get; set; }
        /// <summary>The SMTP address for the user; for example, 'jeff@contoso.onmicrosoft.com'. Read-Only. Supports /$filter.</summary>
        public string Mail { get; set; }
        /// <summary>Mail address of user. Note: type and postOfficeBox are not supported for educationUser resources.</summary>
        public PhysicalAddress MailingAddress { get; set; }
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Supports /$filter.</summary>
        public string MailNickname { get; set; }
        /// <summary>The middle name of user.</summary>
        public string MiddleName { get; set; }
        /// <summary>The primary cellular telephone number for the user.</summary>
        public string MobilePhone { get; set; }
        public string OfficeLocation { get; set; }
        /// <summary>Additional information used to associate the AAD user with it's Active Directory counterpart.</summary>
        public EducationOnPremisesInfo OnPremisesInfo { get; set; }
        /// <summary>Specifies password policies for the user. See standard [user] resource for additional details.</summary>
        public string PasswordPolicies { get; set; }
        /// <summary>Specifies the password profile for the user. The profile contains the user's password. This property is required when a user is created. See standard [user] resource for additional details.</summary>
        public ApiSdk.Models.Microsoft.Graph.PasswordProfile PasswordProfile { get; set; }
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example, 'en-US'.</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>Default role for a user. The user's role might be different in an individual class. Possible values are: student, teacher, faculty. Supports /$filter.</summary>
        public EducationUserRole? PrimaryRole { get; set; }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable.</summary>
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
        /// <summary>Related records related to the user. Possible relationships are parent, relative, aide, doctor, guardian, child, other, unknownFutureValue</summary>
        public List<RelatedContact> RelatedContacts { get; set; }
        /// <summary>Address where user lives. Note: type and postOfficeBox are not supported for educationUser resources.</summary>
        public PhysicalAddress ResidenceAddress { get; set; }
        public List<EducationRubric> Rubrics { get; set; }
        /// <summary>Schools to which the user belongs. Nullable.</summary>
        public List<EducationSchool> Schools { get; set; }
        /// <summary>true if the Outlook global address list should contain this user, otherwise false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.</summary>
        public bool? ShowInAddressList { get; set; }
        /// <summary>If the primary role is student, this block will contain student specific data.</summary>
        public EducationStudent Student { get; set; }
        /// <summary>The user's surname (family name or last name). Supports /$filter.</summary>
        public string Surname { get; set; }
        /// <summary>Classes for which the user is a teacher.</summary>
        public List<EducationClass> TaughtClasses { get; set; }
        /// <summary>If the primary role is teacher, this block will contain teacher specific data.</summary>
        public EducationTeacher Teacher { get; set; }
        /// <summary>A two-letter country code ([ISO 3166 Alpha-2]). Required for users who will be assigned licenses. Not nullable. Supports /$filter.</summary>
        public string UsageLocation { get; set; }
        /// <summary>The directory user corresponding to this user.</summary>
        public ApiSdk.Models.Microsoft.Graph.User User { get; set; }
        /// <summary>The user principal name (UPN) for the user. Supports $filter and $orderby. See standard [user] resource for additional details.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>A string value that can be used to classify user types in your directory, such as 'Member' and 'Guest'. Supports /$filter.</summary>
        public string UserType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountEnabled", (o,n) => { (o as EducationUser).AccountEnabled = n.GetBoolValue(); } },
                {"assignedLicenses", (o,n) => { (o as EducationUser).AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedPlans", (o,n) => { (o as EducationUser).AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", (o,n) => { (o as EducationUser).Assignments = n.GetCollectionOfObjectValues<EducationAssignment>(EducationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"businessPhones", (o,n) => { (o as EducationUser).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"classes", (o,n) => { (o as EducationUser).Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", (o,n) => { (o as EducationUser).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"department", (o,n) => { (o as EducationUser).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as EducationUser).DisplayName = n.GetStringValue(); } },
                {"externalSource", (o,n) => { (o as EducationUser).ExternalSource = n.GetEnumValue<EducationExternalSource>(); } },
                {"externalSourceDetail", (o,n) => { (o as EducationUser).ExternalSourceDetail = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as EducationUser).GivenName = n.GetStringValue(); } },
                {"mail", (o,n) => { (o as EducationUser).Mail = n.GetStringValue(); } },
                {"mailingAddress", (o,n) => { (o as EducationUser).MailingAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"mailNickname", (o,n) => { (o as EducationUser).MailNickname = n.GetStringValue(); } },
                {"middleName", (o,n) => { (o as EducationUser).MiddleName = n.GetStringValue(); } },
                {"mobilePhone", (o,n) => { (o as EducationUser).MobilePhone = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as EducationUser).OfficeLocation = n.GetStringValue(); } },
                {"onPremisesInfo", (o,n) => { (o as EducationUser).OnPremisesInfo = n.GetObjectValue<EducationOnPremisesInfo>(EducationOnPremisesInfo.CreateFromDiscriminatorValue); } },
                {"passwordPolicies", (o,n) => { (o as EducationUser).PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", (o,n) => { (o as EducationUser).PasswordProfile = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PasswordProfile>(ApiSdk.Models.Microsoft.Graph.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"preferredLanguage", (o,n) => { (o as EducationUser).PreferredLanguage = n.GetStringValue(); } },
                {"primaryRole", (o,n) => { (o as EducationUser).PrimaryRole = n.GetEnumValue<EducationUserRole>(); } },
                {"provisionedPlans", (o,n) => { (o as EducationUser).ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"refreshTokensValidFromDateTime", (o,n) => { (o as EducationUser).RefreshTokensValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"relatedContacts", (o,n) => { (o as EducationUser).RelatedContacts = n.GetCollectionOfObjectValues<RelatedContact>(RelatedContact.CreateFromDiscriminatorValue).ToList(); } },
                {"residenceAddress", (o,n) => { (o as EducationUser).ResidenceAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"rubrics", (o,n) => { (o as EducationUser).Rubrics = n.GetCollectionOfObjectValues<EducationRubric>(EducationRubric.CreateFromDiscriminatorValue).ToList(); } },
                {"schools", (o,n) => { (o as EducationUser).Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue).ToList(); } },
                {"showInAddressList", (o,n) => { (o as EducationUser).ShowInAddressList = n.GetBoolValue(); } },
                {"student", (o,n) => { (o as EducationUser).Student = n.GetObjectValue<EducationStudent>(EducationStudent.CreateFromDiscriminatorValue); } },
                {"surname", (o,n) => { (o as EducationUser).Surname = n.GetStringValue(); } },
                {"taughtClasses", (o,n) => { (o as EducationUser).TaughtClasses = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"teacher", (o,n) => { (o as EducationUser).Teacher = n.GetObjectValue<EducationTeacher>(EducationTeacher.CreateFromDiscriminatorValue); } },
                {"usageLocation", (o,n) => { (o as EducationUser).UsageLocation = n.GetStringValue(); } },
                {"user", (o,n) => { (o as EducationUser).User = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.User>(ApiSdk.Models.Microsoft.Graph.User.CreateFromDiscriminatorValue); } },
                {"userPrincipalName", (o,n) => { (o as EducationUser).UserPrincipalName = n.GetStringValue(); } },
                {"userType", (o,n) => { (o as EducationUser).UserType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteCollectionOfObjectValues<EducationAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EducationExternalSource>("externalSource", ExternalSource);
            writer.WriteStringValue("externalSourceDetail", ExternalSourceDetail);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<PhysicalAddress>("mailingAddress", MailingAddress);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<EducationOnPremisesInfo>("onPremisesInfo", OnPremisesInfo);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteEnumValue<EducationUserRole>("primaryRole", PrimaryRole);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteDateTimeOffsetValue("refreshTokensValidFromDateTime", RefreshTokensValidFromDateTime);
            writer.WriteCollectionOfObjectValues<RelatedContact>("relatedContacts", RelatedContacts);
            writer.WriteObjectValue<PhysicalAddress>("residenceAddress", ResidenceAddress);
            writer.WriteCollectionOfObjectValues<EducationRubric>("rubrics", Rubrics);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteObjectValue<EducationStudent>("student", Student);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<EducationClass>("taughtClasses", TaughtClasses);
            writer.WriteObjectValue<EducationTeacher>("teacher", Teacher);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.User>("user", User);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}
