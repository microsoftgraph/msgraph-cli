using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttributeDefinitionMetadata {
        [EnumMember(Value = "BaseAttributeName")]
        BaseAttributeName,
        [EnumMember(Value = "ComplexObjectDefinition")]
        ComplexObjectDefinition,
        [EnumMember(Value = "IsContainer")]
        IsContainer,
        [EnumMember(Value = "IsCustomerDefined")]
        IsCustomerDefined,
        [EnumMember(Value = "IsDomainQualified")]
        IsDomainQualified,
        [EnumMember(Value = "LinkPropertyNames")]
        LinkPropertyNames,
        [EnumMember(Value = "LinkTypeName")]
        LinkTypeName,
        [EnumMember(Value = "MaximumLength")]
        MaximumLength,
        [EnumMember(Value = "ReferencedProperty")]
        ReferencedProperty,
    }
}
