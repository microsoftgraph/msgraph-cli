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
    public partial class DeviceConfigurationUserOverview : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Version of the policy for that overview</summary>
        public int? ConfigurationVersion { get; set; }
        /// <summary>Number of error Users</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed Users</summary>
        public int? FailedCount { get; set; }
        /// <summary>Last update time</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of pending Users</summary>
        public int? PendingCount { get; set; }
        /// <summary>Number of succeeded Users</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceConfigurationUserOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceConfigurationUserOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceConfigurationUserOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurationVersion", n => { ConfigurationVersion = n.GetIntValue(); } },
                { "errorCount", n => { ErrorCount = n.GetIntValue(); } },
                { "failedCount", n => { FailedCount = n.GetIntValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                { "pendingCount", n => { PendingCount = n.GetIntValue(); } },
                { "successCount", n => { SuccessCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("configurationVersion", ConfigurationVersion);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
#pragma warning restore CS0618
