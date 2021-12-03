using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserSecurityState : IParsable {
        /// <summary>AAD User object identifier (GUID) - represents the physical/multi-account user entity.</summary>
        public string AadUserId { get; set; }
        /// <summary>Account name of user account (without Active Directory domain or DNS domain) - (also called mailNickName).</summary>
        public string AccountName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>NetBIOS/Active Directory domain of user account (that is, domain/account format).</summary>
        public string DomainName { get; set; }
        /// <summary>For email-related alerts - user account's email 'role'. Possible values are: unknown, sender, recipient.</summary>
        public EmailRole? EmailRole { get; set; }
        /// <summary>Indicates whether the user logged on through a VPN.</summary>
        public bool? IsVpn { get; set; }
        /// <summary>Time at which the sign-in occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LogonDateTime { get; set; }
        /// <summary>User sign-in ID.</summary>
        public string LogonId { get; set; }
        /// <summary>IP Address the sign-in request originated from.</summary>
        public string LogonIp { get; set; }
        /// <summary>Location (by IP address mapping) associated with a user sign-in event by this user.</summary>
        public string LogonLocation { get; set; }
        /// <summary>Method of user sign in. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
        public LogonType? LogonType { get; set; }
        /// <summary>Active Directory (on-premises) Security Identifier (SID) of the user.</summary>
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>Provider-generated/calculated risk score of the user account. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>User account type (group membership), per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public UserAccountSecurityType? UserAccountType { get; set; }
        /// <summary>User sign-in name - internet format: (user account name)@(user account DNS domain name).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new userSecurityState and sets the default values.
        /// </summary>
        public UserSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aadUserId", (o,n) => { (o as UserSecurityState).AadUserId = n.GetStringValue(); } },
                {"accountName", (o,n) => { (o as UserSecurityState).AccountName = n.GetStringValue(); } },
                {"domainName", (o,n) => { (o as UserSecurityState).DomainName = n.GetStringValue(); } },
                {"emailRole", (o,n) => { (o as UserSecurityState).EmailRole = n.GetEnumValue<EmailRole>(); } },
                {"isVpn", (o,n) => { (o as UserSecurityState).IsVpn = n.GetBoolValue(); } },
                {"logonDateTime", (o,n) => { (o as UserSecurityState).LogonDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonId", (o,n) => { (o as UserSecurityState).LogonId = n.GetStringValue(); } },
                {"logonIp", (o,n) => { (o as UserSecurityState).LogonIp = n.GetStringValue(); } },
                {"logonLocation", (o,n) => { (o as UserSecurityState).LogonLocation = n.GetStringValue(); } },
                {"logonType", (o,n) => { (o as UserSecurityState).LogonType = n.GetEnumValue<LogonType>(); } },
                {"onPremisesSecurityIdentifier", (o,n) => { (o as UserSecurityState).OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"riskScore", (o,n) => { (o as UserSecurityState).RiskScore = n.GetStringValue(); } },
                {"userAccountType", (o,n) => { (o as UserSecurityState).UserAccountType = n.GetEnumValue<UserAccountSecurityType>(); } },
                {"userPrincipalName", (o,n) => { (o as UserSecurityState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("aadUserId", AadUserId);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteEnumValue<EmailRole>("emailRole", EmailRole);
            writer.WriteBoolValue("isVpn", IsVpn);
            writer.WriteDateTimeOffsetValue("logonDateTime", LogonDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteStringValue("logonIp", LogonIp);
            writer.WriteStringValue("logonLocation", LogonLocation);
            writer.WriteEnumValue<LogonType>("logonType", LogonType);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteEnumValue<UserAccountSecurityType>("userAccountType", UserAccountType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
