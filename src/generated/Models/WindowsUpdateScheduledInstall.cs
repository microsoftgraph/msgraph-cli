// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WindowsUpdateScheduledInstall : global::ApiSdk.Models.WindowsUpdateInstallScheduleType, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Possible values for a weekly schedule.</summary>
        public global::ApiSdk.Models.WeeklySchedule? ScheduledInstallDay { get; set; }
        /// <summary>Scheduled Install Time during day</summary>
        public Time? ScheduledInstallTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsUpdateScheduledInstall"/> and sets the default values.
        /// </summary>
        public WindowsUpdateScheduledInstall() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdateScheduledInstall";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsUpdateScheduledInstall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsUpdateScheduledInstall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsUpdateScheduledInstall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "scheduledInstallDay", n => { ScheduledInstallDay = n.GetEnumValue<global::ApiSdk.Models.WeeklySchedule>(); } },
                { "scheduledInstallTime", n => { ScheduledInstallTime = n.GetTimeValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.WeeklySchedule>("scheduledInstallDay", ScheduledInstallDay);
            writer.WriteTimeValue("scheduledInstallTime", ScheduledInstallTime);
        }
    }
}
#pragma warning restore CS0618
