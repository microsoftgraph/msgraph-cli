using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
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
        /// <summary>The SMTP address for the user; for example, &apos;jeff@contoso.onmicrosoft.com&apos;. Read-Only. Supports /$filter.</summary>
        public string Mail { get; set; }
        /// <summary>Mail address of user. Note: type and postOfficeBox are not supported for educationUser resources.</summary>
        public PhysicalAddress MailingAddress { get; set; }
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Supports /$filter.</summary>
        public string MailNickname { get; set; }
        /// <summary>The middle name of user.</summary>
        public string MiddleName { get; set; }
        /// <summary>The primary cellular telephone number for the user.</summary>
        public string MobilePhone { get; set; }
        /// <summary>The officeLocation property</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Additional information used to associate the AAD user with it&apos;s Active Directory counterpart.</summary>
        public EducationOnPremisesInfo OnPremisesInfo { get; set; }
        /// <summary>Specifies password policies for the user. See standard [user] resource for additional details.</summary>
        public string PasswordPolicies { get; set; }
        /// <summary>Specifies the password profile for the user. The profile contains the user&apos;s password. This property is required when a user is created. See standard [user] resource for additional details.</summary>
        public ApiSdk.Models.PasswordProfile PasswordProfile { get; set; }
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example, &apos;en-US&apos;.</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>Default role for a user. The user&apos;s role might be different in an individual class. Possible values are: student, teacher, faculty. Supports /$filter.</summary>
        public EducationUserRole? PrimaryRole { get; set; }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable.</summary>
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
        /// <summary>The refreshTokensValidFromDateTime property</summary>
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
        /// <summary>Related records related to the user. Possible relationships are parent, relative, aide, doctor, guardian, child, other, unknownFutureValue</summary>
        public List<RelatedContact> RelatedContacts { get; set; }
        /// <summary>Address where user lives. Note: type and postOfficeBox are not supported for educationUser resources.</summary>
        public PhysicalAddress ResidenceAddress { get; set; }
        /// <summary>When set, the grading rubric attached to the assignment.</summary>
        public List<EducationRubric> Rubrics { get; set; }
        /// <summary>Schools to which the user belongs. Nullable.</summary>
        public List<EducationSchool> Schools { get; set; }
        /// <summary>True if the Outlook Global Address List should contain this user; otherwise, false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.</summary>
        public bool? ShowInAddressList { get; set; }
        /// <summary>If the primary role is student, this block will contain student specific data.</summary>
        public EducationStudent Student { get; set; }
        /// <summary>The user&apos;s surname (family name or last name). Supports /$filter.</summary>
        public string Surname { get; set; }
        /// <summary>Classes for which the user is a teacher.</summary>
        public List<EducationClass> TaughtClasses { get; set; }
        /// <summary>If the primary role is teacher, this block will contain teacher specific data.</summary>
        public EducationTeacher Teacher { get; set; }
        /// <summary>A two-letter country code ([ISO 3166 Alpha-2]). Required for users who will be assigned licenses. Not nullable. Supports /$filter.</summary>
        public string UsageLocation { get; set; }
        /// <summary>The directory user that corresponds to this user.</summary>
        public ApiSdk.Models.User User { get; set; }
        /// <summary>The user principal name (UPN) for the user. Supports $filter and $orderby. See standard [user] resource for additional details.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>A string value that can be used to classify user types in your directory, such as &apos;Member&apos; and &apos;Guest&apos;. Supports /$filter.</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EducationAssignment>(EducationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalSource", n => { ExternalSource = n.GetEnumValue<EducationExternalSource>(); } },
                {"externalSourceDetail", n => { ExternalSourceDetail = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailingAddress", n => { MailingAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"middleName", n => { MiddleName = n.GetStringValue(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"onPremisesInfo", n => { OnPremisesInfo = n.GetObjectValue<EducationOnPremisesInfo>(EducationOnPremisesInfo.CreateFromDiscriminatorValue); } },
                {"passwordPolicies", n => { PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", n => { PasswordProfile = n.GetObjectValue<ApiSdk.Models.PasswordProfile>(ApiSdk.Models.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"primaryRole", n => { PrimaryRole = n.GetEnumValue<EducationUserRole>(); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"refreshTokensValidFromDateTime", n => { RefreshTokensValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"relatedContacts", n => { RelatedContacts = n.GetCollectionOfObjectValues<RelatedContact>(RelatedContact.CreateFromDiscriminatorValue).ToList(); } },
                {"residenceAddress", n => { ResidenceAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"rubrics", n => { Rubrics = n.GetCollectionOfObjectValues<EducationRubric>(EducationRubric.CreateFromDiscriminatorValue).ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue).ToList(); } },
                {"showInAddressList", n => { ShowInAddressList = n.GetBoolValue(); } },
                {"student", n => { Student = n.GetObjectValue<EducationStudent>(EducationStudent.CreateFromDiscriminatorValue); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"taughtClasses", n => { TaughtClasses = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"teacher", n => { Teacher = n.GetObjectValue<EducationTeacher>(EducationTeacher.CreateFromDiscriminatorValue); } },
                {"usageLocation", n => { UsageLocation = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.PasswordProfile>("passwordProfile", PasswordProfile);
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
            writer.WriteObjectValue<ApiSdk.Models.User>("user", User);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}
