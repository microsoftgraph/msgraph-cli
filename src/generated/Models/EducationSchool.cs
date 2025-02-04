// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EducationSchool : global::ApiSdk.Models.EducationOrganization, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Address of the school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PhysicalAddress? Address { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PhysicalAddress Address { get; set; }
#endif
        /// <summary>The underlying administrativeUnit for this school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AdministrativeUnit? AdministrativeUnit { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AdministrativeUnit AdministrativeUnit { get; set; }
#endif
        /// <summary>Classes taught at the school. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EducationClass>? Classes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EducationClass> Classes { get; set; }
#endif
        /// <summary>Entity who created the school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>ID of school in syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>ID of principal in syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalPrincipalId { get; set; }
#nullable restore
#else
        public string ExternalPrincipalId { get; set; }
#endif
        /// <summary>The fax property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax { get; set; }
#nullable restore
#else
        public string Fax { get; set; }
#endif
        /// <summary>Highest grade taught.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HighestGrade { get; set; }
#nullable restore
#else
        public string HighestGrade { get; set; }
#endif
        /// <summary>Lowest grade taught.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LowestGrade { get; set; }
#nullable restore
#else
        public string LowestGrade { get; set; }
#endif
        /// <summary>Phone number of school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Email address of the principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalEmail { get; set; }
#nullable restore
#else
        public string PrincipalEmail { get; set; }
#endif
        /// <summary>Name of the principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName { get; set; }
#nullable restore
#else
        public string PrincipalName { get; set; }
#endif
        /// <summary>School Number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchoolNumber { get; set; }
#nullable restore
#else
        public string SchoolNumber { get; set; }
#endif
        /// <summary>Users in the school. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EducationUser>? Users { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EducationUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EducationSchool"/> and sets the default values.
        /// </summary>
        public EducationSchool() : base()
        {
            OdataType = "#microsoft.graph.educationSchool";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EducationSchool"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EducationSchool CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EducationSchool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "address", n => { Address = n.GetObjectValue<global::ApiSdk.Models.PhysicalAddress>(global::ApiSdk.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "administrativeUnit", n => { AdministrativeUnit = n.GetObjectValue<global::ApiSdk.Models.AdministrativeUnit>(global::ApiSdk.Models.AdministrativeUnit.CreateFromDiscriminatorValue); } },
                { "classes", n => { Classes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EducationClass>(global::ApiSdk.Models.EducationClass.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalPrincipalId", n => { ExternalPrincipalId = n.GetStringValue(); } },
                { "fax", n => { Fax = n.GetStringValue(); } },
                { "highestGrade", n => { HighestGrade = n.GetStringValue(); } },
                { "lowestGrade", n => { LowestGrade = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "principalEmail", n => { PrincipalEmail = n.GetStringValue(); } },
                { "principalName", n => { PrincipalName = n.GetStringValue(); } },
                { "schoolNumber", n => { SchoolNumber = n.GetStringValue(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EducationUser>(global::ApiSdk.Models.EducationUser.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.PhysicalAddress>("address", Address);
            writer.WriteObjectValue<global::ApiSdk.Models.AdministrativeUnit>("administrativeUnit", AdministrativeUnit);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EducationClass>("classes", Classes);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalPrincipalId", ExternalPrincipalId);
            writer.WriteStringValue("fax", Fax);
            writer.WriteStringValue("highestGrade", HighestGrade);
            writer.WriteStringValue("lowestGrade", LowestGrade);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("principalEmail", PrincipalEmail);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("schoolNumber", SchoolNumber);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EducationUser>("users", Users);
        }
    }
}
#pragma warning restore CS0618
