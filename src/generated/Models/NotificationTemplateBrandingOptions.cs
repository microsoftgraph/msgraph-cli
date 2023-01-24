namespace ApiSdk.Models {
    /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
    public enum NotificationTemplateBrandingOptions {
        /// <summary>No Branding.</summary>
        None,
        /// <summary>Include Company Logo.</summary>
        IncludeCompanyLogo,
        /// <summary>Include Company Name.</summary>
        IncludeCompanyName,
        /// <summary>Include Contact Info.</summary>
        IncludeContactInformation,
        /// <summary>Include Company Portal Link.</summary>
        IncludeCompanyPortalLink,
        /// <summary>Include Device Details.</summary>
        IncludeDeviceDetails,
    }
}
