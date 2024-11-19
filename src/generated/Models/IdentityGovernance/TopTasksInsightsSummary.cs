// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TopTasksInsightsSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of failed runs of the task.</summary>
        public int? FailedTasks { get; set; }
        /// <summary>Count of failed users who were processed by the task.</summary>
        public int? FailedUsers { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Count of successful runs of the task.</summary>
        public int? SuccessfulTasks { get; set; }
        /// <summary>Count of successful users processed by the task.</summary>
        public int? SuccessfulUsers { get; set; }
        /// <summary>The name of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskDefinitionDisplayName { get; set; }
#nullable restore
#else
        public string TaskDefinitionDisplayName { get; set; }
#endif
        /// <summary>The task ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskDefinitionId { get; set; }
#nullable restore
#else
        public string TaskDefinitionId { get; set; }
#endif
        /// <summary>Count of total runs of the task.</summary>
        public int? TotalTasks { get; set; }
        /// <summary>Count of total users processed by the task.</summary>
        public int? TotalUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IdentityGovernance.TopTasksInsightsSummary"/> and sets the default values.
        /// </summary>
        public TopTasksInsightsSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IdentityGovernance.TopTasksInsightsSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.IdentityGovernance.TopTasksInsightsSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IdentityGovernance.TopTasksInsightsSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                { "failedUsers", n => { FailedUsers = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "successfulTasks", n => { SuccessfulTasks = n.GetIntValue(); } },
                { "successfulUsers", n => { SuccessfulUsers = n.GetIntValue(); } },
                { "taskDefinitionDisplayName", n => { TaskDefinitionDisplayName = n.GetStringValue(); } },
                { "taskDefinitionId", n => { TaskDefinitionId = n.GetStringValue(); } },
                { "totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                { "totalUsers", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteIntValue("failedUsers", FailedUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulTasks", SuccessfulTasks);
            writer.WriteIntValue("successfulUsers", SuccessfulUsers);
            writer.WriteStringValue("taskDefinitionDisplayName", TaskDefinitionDisplayName);
            writer.WriteStringValue("taskDefinitionId", TaskDefinitionId);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618