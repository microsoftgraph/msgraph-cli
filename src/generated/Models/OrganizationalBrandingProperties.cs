using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundColor { get; set; }
#nullable restore
#else
        public string BackgroundColor { get; set; }
#endif
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? BackgroundImage { get; set; }
#nullable restore
#else
        public byte[] BackgroundImage { get; set; }
#endif
        /// <summary>A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundImageRelativeUrl { get; set; }
#nullable restore
#else
        public string BackgroundImageRelativeUrl { get; set; }
#endif
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? BannerLogo { get; set; }
#nullable restore
#else
        public byte[] BannerLogo { get; set; }
#endif
        /// <summary>A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BannerLogoRelativeUrl { get; set; }
#nullable restore
#else
        public string BannerLogoRelativeUrl { get; set; }
#endif
        /// <summary>A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CdnList { get; set; }
#nullable restore
#else
        public List<string> CdnList { get; set; }
#endif
        /// <summary>The customAccountResetCredentialsUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomAccountResetCredentialsUrl { get; set; }
#nullable restore
#else
        public string CustomAccountResetCredentialsUrl { get; set; }
#endif
        /// <summary>The customCannotAccessYourAccountText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCannotAccessYourAccountText { get; set; }
#nullable restore
#else
        public string CustomCannotAccessYourAccountText { get; set; }
#endif
        /// <summary>The customCannotAccessYourAccountUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCannotAccessYourAccountUrl { get; set; }
#nullable restore
#else
        public string CustomCannotAccessYourAccountUrl { get; set; }
#endif
        /// <summary>The customCSS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? CustomCSS { get; set; }
#nullable restore
#else
        public byte[] CustomCSS { get; set; }
#endif
        /// <summary>The customCSSRelativeUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCSSRelativeUrl { get; set; }
#nullable restore
#else
        public string CustomCSSRelativeUrl { get; set; }
#endif
        /// <summary>The customForgotMyPasswordText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomForgotMyPasswordText { get; set; }
#nullable restore
#else
        public string CustomForgotMyPasswordText { get; set; }
#endif
        /// <summary>The customPrivacyAndCookiesText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPrivacyAndCookiesText { get; set; }
#nullable restore
#else
        public string CustomPrivacyAndCookiesText { get; set; }
#endif
        /// <summary>The customPrivacyAndCookiesUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPrivacyAndCookiesUrl { get; set; }
#nullable restore
#else
        public string CustomPrivacyAndCookiesUrl { get; set; }
#endif
        /// <summary>The customResetItNowText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomResetItNowText { get; set; }
#nullable restore
#else
        public string CustomResetItNowText { get; set; }
#endif
        /// <summary>The customTermsOfUseText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomTermsOfUseText { get; set; }
#nullable restore
#else
        public string CustomTermsOfUseText { get; set; }
#endif
        /// <summary>The customTermsOfUseUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomTermsOfUseUrl { get; set; }
#nullable restore
#else
        public string CustomTermsOfUseUrl { get; set; }
#endif
        /// <summary>The favicon property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Favicon { get; set; }
#nullable restore
#else
        public byte[] Favicon { get; set; }
#endif
        /// <summary>The faviconRelativeUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaviconRelativeUrl { get; set; }
#nullable restore
#else
        public string FaviconRelativeUrl { get; set; }
#endif
        /// <summary>The headerBackgroundColor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderBackgroundColor { get; set; }
#nullable restore
#else
        public string HeaderBackgroundColor { get; set; }
#endif
        /// <summary>The headerLogo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? HeaderLogo { get; set; }
#nullable restore
#else
        public byte[] HeaderLogo { get; set; }
#endif
        /// <summary>The headerLogoRelativeUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderLogoRelativeUrl { get; set; }
#nullable restore
#else
        public string HeaderLogoRelativeUrl { get; set; }
#endif
        /// <summary>The loginPageLayoutConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.LoginPageLayoutConfiguration? LoginPageLayoutConfiguration { get; set; }
#nullable restore
#else
        public ApiSdk.Models.LoginPageLayoutConfiguration LoginPageLayoutConfiguration { get; set; }
#endif
        /// <summary>The loginPageTextVisibilitySettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.LoginPageTextVisibilitySettings? LoginPageTextVisibilitySettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings { get; set; }
#endif
        /// <summary>Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInPageText { get; set; }
#nullable restore
#else
        public string SignInPageText { get; set; }
#endif
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? SquareLogo { get; set; }
#nullable restore
#else
        public byte[] SquareLogo { get; set; }
#endif
        /// <summary>The squareLogoDark property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? SquareLogoDark { get; set; }
#nullable restore
#else
        public byte[] SquareLogoDark { get; set; }
#endif
        /// <summary>The squareLogoDarkRelativeUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoDarkRelativeUrl { get; set; }
#nullable restore
#else
        public string SquareLogoDarkRelativeUrl { get; set; }
#endif
        /// <summary>A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoRelativeUrl { get; set; }
#nullable restore
#else
        public string SquareLogoRelativeUrl { get; set; }
#endif
        /// <summary>String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can&apos;t exceed 64 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsernameHintText { get; set; }
#nullable restore
#else
        public string UsernameHintText { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OrganizationalBrandingProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.organizationalBranding" => new OrganizationalBranding(),
                "#microsoft.graph.organizationalBrandingLocalization" => new OrganizationalBrandingLocalization(),
                _ => new OrganizationalBrandingProperties(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", n => { BackgroundImage = n.GetByteArrayValue(); } },
                {"backgroundImageRelativeUrl", n => { BackgroundImageRelativeUrl = n.GetStringValue(); } },
                {"bannerLogo", n => { BannerLogo = n.GetByteArrayValue(); } },
                {"bannerLogoRelativeUrl", n => { BannerLogoRelativeUrl = n.GetStringValue(); } },
                {"cdnList", n => { CdnList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"customAccountResetCredentialsUrl", n => { CustomAccountResetCredentialsUrl = n.GetStringValue(); } },
                {"customCannotAccessYourAccountText", n => { CustomCannotAccessYourAccountText = n.GetStringValue(); } },
                {"customCannotAccessYourAccountUrl", n => { CustomCannotAccessYourAccountUrl = n.GetStringValue(); } },
                {"customCSS", n => { CustomCSS = n.GetByteArrayValue(); } },
                {"customCSSRelativeUrl", n => { CustomCSSRelativeUrl = n.GetStringValue(); } },
                {"customForgotMyPasswordText", n => { CustomForgotMyPasswordText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesText", n => { CustomPrivacyAndCookiesText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesUrl", n => { CustomPrivacyAndCookiesUrl = n.GetStringValue(); } },
                {"customResetItNowText", n => { CustomResetItNowText = n.GetStringValue(); } },
                {"customTermsOfUseText", n => { CustomTermsOfUseText = n.GetStringValue(); } },
                {"customTermsOfUseUrl", n => { CustomTermsOfUseUrl = n.GetStringValue(); } },
                {"favicon", n => { Favicon = n.GetByteArrayValue(); } },
                {"faviconRelativeUrl", n => { FaviconRelativeUrl = n.GetStringValue(); } },
                {"headerBackgroundColor", n => { HeaderBackgroundColor = n.GetStringValue(); } },
                {"headerLogo", n => { HeaderLogo = n.GetByteArrayValue(); } },
                {"headerLogoRelativeUrl", n => { HeaderLogoRelativeUrl = n.GetStringValue(); } },
                {"loginPageLayoutConfiguration", n => { LoginPageLayoutConfiguration = n.GetObjectValue<ApiSdk.Models.LoginPageLayoutConfiguration>(ApiSdk.Models.LoginPageLayoutConfiguration.CreateFromDiscriminatorValue); } },
                {"loginPageTextVisibilitySettings", n => { LoginPageTextVisibilitySettings = n.GetObjectValue<ApiSdk.Models.LoginPageTextVisibilitySettings>(ApiSdk.Models.LoginPageTextVisibilitySettings.CreateFromDiscriminatorValue); } },
                {"signInPageText", n => { SignInPageText = n.GetStringValue(); } },
                {"squareLogo", n => { SquareLogo = n.GetByteArrayValue(); } },
                {"squareLogoDark", n => { SquareLogoDark = n.GetByteArrayValue(); } },
                {"squareLogoDarkRelativeUrl", n => { SquareLogoDarkRelativeUrl = n.GetStringValue(); } },
                {"squareLogoRelativeUrl", n => { SquareLogoRelativeUrl = n.GetStringValue(); } },
                {"usernameHintText", n => { UsernameHintText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteByteArrayValue("backgroundImage", BackgroundImage);
            writer.WriteStringValue("backgroundImageRelativeUrl", BackgroundImageRelativeUrl);
            writer.WriteByteArrayValue("bannerLogo", BannerLogo);
            writer.WriteStringValue("bannerLogoRelativeUrl", BannerLogoRelativeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("cdnList", CdnList);
            writer.WriteStringValue("customAccountResetCredentialsUrl", CustomAccountResetCredentialsUrl);
            writer.WriteStringValue("customCannotAccessYourAccountText", CustomCannotAccessYourAccountText);
            writer.WriteStringValue("customCannotAccessYourAccountUrl", CustomCannotAccessYourAccountUrl);
            writer.WriteByteArrayValue("customCSS", CustomCSS);
            writer.WriteStringValue("customCSSRelativeUrl", CustomCSSRelativeUrl);
            writer.WriteStringValue("customForgotMyPasswordText", CustomForgotMyPasswordText);
            writer.WriteStringValue("customPrivacyAndCookiesText", CustomPrivacyAndCookiesText);
            writer.WriteStringValue("customPrivacyAndCookiesUrl", CustomPrivacyAndCookiesUrl);
            writer.WriteStringValue("customResetItNowText", CustomResetItNowText);
            writer.WriteStringValue("customTermsOfUseText", CustomTermsOfUseText);
            writer.WriteStringValue("customTermsOfUseUrl", CustomTermsOfUseUrl);
            writer.WriteByteArrayValue("favicon", Favicon);
            writer.WriteStringValue("faviconRelativeUrl", FaviconRelativeUrl);
            writer.WriteStringValue("headerBackgroundColor", HeaderBackgroundColor);
            writer.WriteByteArrayValue("headerLogo", HeaderLogo);
            writer.WriteStringValue("headerLogoRelativeUrl", HeaderLogoRelativeUrl);
            writer.WriteObjectValue<ApiSdk.Models.LoginPageLayoutConfiguration>("loginPageLayoutConfiguration", LoginPageLayoutConfiguration);
            writer.WriteObjectValue<ApiSdk.Models.LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings", LoginPageTextVisibilitySettings);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteByteArrayValue("squareLogo", SquareLogo);
            writer.WriteByteArrayValue("squareLogoDark", SquareLogoDark);
            writer.WriteStringValue("squareLogoDarkRelativeUrl", SquareLogoDarkRelativeUrl);
            writer.WriteStringValue("squareLogoRelativeUrl", SquareLogoRelativeUrl);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
