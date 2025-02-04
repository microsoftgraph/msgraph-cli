// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.ParseExpression
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ParseExpressionPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression { get; set; }
#nullable restore
#else
        public string Expression { get; set; }
#endif
        /// <summary>The targetAttributeDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AttributeDefinition? TargetAttributeDefinition { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AttributeDefinition TargetAttributeDefinition { get; set; }
#endif
        /// <summary>The testInputObject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ExpressionInputObject? TestInputObject { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ExpressionInputObject TestInputObject { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.ParseExpression.ParseExpressionPostRequestBody"/> and sets the default values.
        /// </summary>
        public ParseExpressionPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.ParseExpression.ParseExpressionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.ParseExpression.ParseExpressionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.ParseExpression.ParseExpressionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "expression", n => { Expression = n.GetStringValue(); } },
                { "targetAttributeDefinition", n => { TargetAttributeDefinition = n.GetObjectValue<global::ApiSdk.Models.AttributeDefinition>(global::ApiSdk.Models.AttributeDefinition.CreateFromDiscriminatorValue); } },
                { "testInputObject", n => { TestInputObject = n.GetObjectValue<global::ApiSdk.Models.ExpressionInputObject>(global::ApiSdk.Models.ExpressionInputObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteObjectValue<global::ApiSdk.Models.AttributeDefinition>("targetAttributeDefinition", TargetAttributeDefinition);
            writer.WriteObjectValue<global::ApiSdk.Models.ExpressionInputObject>("testInputObject", TestInputObject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
