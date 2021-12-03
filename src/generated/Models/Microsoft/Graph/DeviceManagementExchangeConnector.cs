using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceManagementExchangeConnector : Entity, IParsable {
        /// <summary>The name of the server hosting the Exchange Connector.</summary>
        public string ConnectorServerName { get; set; }
        /// <summary>An alias assigned to the Exchange server</summary>
        public string ExchangeAlias { get; set; }
        /// <summary>The type of Exchange Connector Configured. Possible values are: onPremises, hosted, serviceToService, dedicated.</summary>
        public DeviceManagementExchangeConnectorType? ExchangeConnectorType { get; set; }
        /// <summary>Exchange Organization to the Exchange server</summary>
        public string ExchangeOrganization { get; set; }
        /// <summary>Last sync time for the Exchange Connector</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Email address used to configure the Service To Service Exchange Connector.</summary>
        public string PrimarySmtpAddress { get; set; }
        /// <summary>The name of the Exchange server.</summary>
        public string ServerName { get; set; }
        /// <summary>Exchange Connector Status. Possible values are: none, connectionPending, connected, disconnected.</summary>
        public DeviceManagementExchangeConnectorStatus? Status { get; set; }
        /// <summary>The version of the ExchangeConnectorAgent</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"connectorServerName", (o,n) => { (o as DeviceManagementExchangeConnector).ConnectorServerName = n.GetStringValue(); } },
                {"exchangeAlias", (o,n) => { (o as DeviceManagementExchangeConnector).ExchangeAlias = n.GetStringValue(); } },
                {"exchangeConnectorType", (o,n) => { (o as DeviceManagementExchangeConnector).ExchangeConnectorType = n.GetEnumValue<DeviceManagementExchangeConnectorType>(); } },
                {"exchangeOrganization", (o,n) => { (o as DeviceManagementExchangeConnector).ExchangeOrganization = n.GetStringValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as DeviceManagementExchangeConnector).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"primarySmtpAddress", (o,n) => { (o as DeviceManagementExchangeConnector).PrimarySmtpAddress = n.GetStringValue(); } },
                {"serverName", (o,n) => { (o as DeviceManagementExchangeConnector).ServerName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as DeviceManagementExchangeConnector).Status = n.GetEnumValue<DeviceManagementExchangeConnectorStatus>(); } },
                {"version", (o,n) => { (o as DeviceManagementExchangeConnector).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectorServerName", ConnectorServerName);
            writer.WriteStringValue("exchangeAlias", ExchangeAlias);
            writer.WriteEnumValue<DeviceManagementExchangeConnectorType>("exchangeConnectorType", ExchangeConnectorType);
            writer.WriteStringValue("exchangeOrganization", ExchangeOrganization);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("primarySmtpAddress", PrimarySmtpAddress);
            writer.WriteStringValue("serverName", ServerName);
            writer.WriteEnumValue<DeviceManagementExchangeConnectorStatus>("status", Status);
            writer.WriteStringValue("version", Version);
        }
    }
}
