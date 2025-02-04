// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The user experience analytics device model performance entity contains device model performance details.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsAppHealthDeviceModelPerformance : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The number of active devices for the model. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount { get; set; }
        /// <summary>The manufacturer name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer { get; set; }
#nullable restore
#else
        public string DeviceManufacturer { get; set; }
#endif
        /// <summary>The model name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel { get; set; }
#nullable restore
#else
        public string DeviceModel { get; set; }
#endif
        /// <summary>The healthStatus property</summary>
        public global::ApiSdk.Models.UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The mean time to failure for the application in minutes. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>The application health score of the device model. Valid values 0 to 100. Supports: $filter, $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelAppHealthScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                { "deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                { "deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                { "healthStatus", n => { HealthStatus = n.GetEnumValue<global::ApiSdk.Models.UserExperienceAnalyticsHealthState>(); } },
                { "meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                { "modelAppHealthScore", n => { ModelAppHealthScore = n.GetDoubleValue(); } },
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
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<global::ApiSdk.Models.UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDoubleValue("modelAppHealthScore", ModelAppHealthScore);
        }
    }
}
#pragma warning restore CS0618
