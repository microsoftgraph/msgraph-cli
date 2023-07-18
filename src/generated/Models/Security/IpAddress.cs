using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class IpAddress : Host, IParsable {
        /// <summary>The details about the autonomous system to which this IP address belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.AutonomousSystem? AutonomousSystem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.AutonomousSystem AutonomousSystem { get; set; }
#endif
        /// <summary>The country or region for this IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion { get; set; }
#nullable restore
#else
        public string CountryOrRegion { get; set; }
#endif
        /// <summary>The hosting company listed for this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostingProvider { get; set; }
#nullable restore
#else
        public string HostingProvider { get; set; }
#endif
        /// <summary>The block of IP addresses this IP address belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Netblock { get; set; }
#nullable restore
#else
        public string Netblock { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ipAddress and sets the default values.
        /// </summary>
        public IpAddress() : base() {
            OdataType = "#microsoft.graph.security.ipAddress";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autonomousSystem", n => { AutonomousSystem = n.GetObjectValue<ApiSdk.Models.Security.AutonomousSystem>(ApiSdk.Models.Security.AutonomousSystem.CreateFromDiscriminatorValue); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"hostingProvider", n => { HostingProvider = n.GetStringValue(); } },
                {"netblock", n => { Netblock = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Security.AutonomousSystem>("autonomousSystem", AutonomousSystem);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("hostingProvider", HostingProvider);
            writer.WriteStringValue("netblock", Netblock);
        }
    }
}
