using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ColumnDefinition : Entity, IParsable {
        /// <summary>This column stores boolean values.</summary>
        public ApiSdk.Models.Microsoft.Graph.BooleanColumn Boolean { get; set; }
        /// <summary>This column's data is calculated based on other columns.</summary>
        public ApiSdk.Models.Microsoft.Graph.CalculatedColumn Calculated { get; set; }
        /// <summary>This column stores data from a list of choices.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChoiceColumn Choice { get; set; }
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
        public string ColumnGroup { get; set; }
        /// <summary>This column stores content approval status.</summary>
        public ApiSdk.Models.Microsoft.Graph.ContentApprovalStatusColumn ContentApprovalStatus { get; set; }
        /// <summary>This column stores currency values.</summary>
        public ApiSdk.Models.Microsoft.Graph.CurrencyColumn Currency { get; set; }
        /// <summary>This column stores DateTime values.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeColumn DateTime { get; set; }
        /// <summary>The default value for this column.</summary>
        public ApiSdk.Models.Microsoft.Graph.DefaultColumnValue DefaultValue { get; set; }
        /// <summary>The user-facing description of the column.</summary>
        public string Description { get; set; }
        /// <summary>The user-facing name of the column.</summary>
        public string DisplayName { get; set; }
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues { get; set; }
        /// <summary>This column stores a geolocation.</summary>
        public ApiSdk.Models.Microsoft.Graph.GeolocationColumn Geolocation { get; set; }
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden { get; set; }
        /// <summary>This column stores hyperlink or picture values.</summary>
        public ApiSdk.Models.Microsoft.Graph.HyperlinkOrPictureColumn HyperlinkOrPicture { get; set; }
        /// <summary>Specifies whether the column values can be used for sorting and searching.</summary>
        public bool? Indexed { get; set; }
        /// <summary>Indicates whether this column can be deleted.</summary>
        public bool? IsDeletable { get; set; }
        /// <summary>Indicates whether values in the column can be reordered. Read-only.</summary>
        public bool? IsReorderable { get; set; }
        /// <summary>Specifies whether the column can be changed.</summary>
        public bool? IsSealed { get; set; }
        /// <summary>This column's data is looked up from another source in the site.</summary>
        public ApiSdk.Models.Microsoft.Graph.LookupColumn Lookup { get; set; }
        /// <summary>The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.</summary>
        public string Name { get; set; }
        /// <summary>This column stores number values.</summary>
        public ApiSdk.Models.Microsoft.Graph.NumberColumn Number { get; set; }
        /// <summary>This column stores Person or Group values.</summary>
        public ApiSdk.Models.Microsoft.Graph.PersonOrGroupColumn PersonOrGroup { get; set; }
        /// <summary>If 'true', changes to this column will be propagated to lists that implement the column.</summary>
        public bool? PropagateChanges { get; set; }
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>Specifies whether the column value isn't optional.</summary>
        public bool? Required { get; set; }
        /// <summary>The source column for the content type column.</summary>
        public ApiSdk.Models.Microsoft.Graph.ColumnDefinition SourceColumn { get; set; }
        /// <summary>ContentType from which this column is inherited from. Present only in contentTypes columns response. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ContentTypeInfo SourceContentType { get; set; }
        /// <summary>This column stores taxonomy terms.</summary>
        public ApiSdk.Models.Microsoft.Graph.TermColumn Term { get; set; }
        /// <summary>This column stores text values.</summary>
        public ApiSdk.Models.Microsoft.Graph.TextColumn Text { get; set; }
        /// <summary>This column stores thumbnail values.</summary>
        public ApiSdk.Models.Microsoft.Graph.ThumbnailColumn Thumbnail { get; set; }
        /// <summary>For site columns, the type of column. Read-only.</summary>
        public ColumnTypes? Type { get; set; }
        /// <summary>This column stores validation formula and message for the column.</summary>
        public ApiSdk.Models.Microsoft.Graph.ColumnValidation Validation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ColumnDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ColumnDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"boolean", (o,n) => { (o as ColumnDefinition).Boolean = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.BooleanColumn>(ApiSdk.Models.Microsoft.Graph.BooleanColumn.CreateFromDiscriminatorValue); } },
                {"calculated", (o,n) => { (o as ColumnDefinition).Calculated = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CalculatedColumn>(ApiSdk.Models.Microsoft.Graph.CalculatedColumn.CreateFromDiscriminatorValue); } },
                {"choice", (o,n) => { (o as ColumnDefinition).Choice = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChoiceColumn>(ApiSdk.Models.Microsoft.Graph.ChoiceColumn.CreateFromDiscriminatorValue); } },
                {"columnGroup", (o,n) => { (o as ColumnDefinition).ColumnGroup = n.GetStringValue(); } },
                {"contentApprovalStatus", (o,n) => { (o as ColumnDefinition).ContentApprovalStatus = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ContentApprovalStatusColumn>(ApiSdk.Models.Microsoft.Graph.ContentApprovalStatusColumn.CreateFromDiscriminatorValue); } },
                {"currency", (o,n) => { (o as ColumnDefinition).Currency = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CurrencyColumn>(ApiSdk.Models.Microsoft.Graph.CurrencyColumn.CreateFromDiscriminatorValue); } },
                {"dateTime", (o,n) => { (o as ColumnDefinition).DateTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeColumn>(ApiSdk.Models.Microsoft.Graph.DateTimeColumn.CreateFromDiscriminatorValue); } },
                {"defaultValue", (o,n) => { (o as ColumnDefinition).DefaultValue = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DefaultColumnValue>(ApiSdk.Models.Microsoft.Graph.DefaultColumnValue.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as ColumnDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ColumnDefinition).DisplayName = n.GetStringValue(); } },
                {"enforceUniqueValues", (o,n) => { (o as ColumnDefinition).EnforceUniqueValues = n.GetBoolValue(); } },
                {"geolocation", (o,n) => { (o as ColumnDefinition).Geolocation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.GeolocationColumn>(ApiSdk.Models.Microsoft.Graph.GeolocationColumn.CreateFromDiscriminatorValue); } },
                {"hidden", (o,n) => { (o as ColumnDefinition).Hidden = n.GetBoolValue(); } },
                {"hyperlinkOrPicture", (o,n) => { (o as ColumnDefinition).HyperlinkOrPicture = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.HyperlinkOrPictureColumn>(ApiSdk.Models.Microsoft.Graph.HyperlinkOrPictureColumn.CreateFromDiscriminatorValue); } },
                {"indexed", (o,n) => { (o as ColumnDefinition).Indexed = n.GetBoolValue(); } },
                {"isDeletable", (o,n) => { (o as ColumnDefinition).IsDeletable = n.GetBoolValue(); } },
                {"isReorderable", (o,n) => { (o as ColumnDefinition).IsReorderable = n.GetBoolValue(); } },
                {"isSealed", (o,n) => { (o as ColumnDefinition).IsSealed = n.GetBoolValue(); } },
                {"lookup", (o,n) => { (o as ColumnDefinition).Lookup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.LookupColumn>(ApiSdk.Models.Microsoft.Graph.LookupColumn.CreateFromDiscriminatorValue); } },
                {"name", (o,n) => { (o as ColumnDefinition).Name = n.GetStringValue(); } },
                {"number", (o,n) => { (o as ColumnDefinition).Number = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.NumberColumn>(ApiSdk.Models.Microsoft.Graph.NumberColumn.CreateFromDiscriminatorValue); } },
                {"personOrGroup", (o,n) => { (o as ColumnDefinition).PersonOrGroup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PersonOrGroupColumn>(ApiSdk.Models.Microsoft.Graph.PersonOrGroupColumn.CreateFromDiscriminatorValue); } },
                {"propagateChanges", (o,n) => { (o as ColumnDefinition).PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", (o,n) => { (o as ColumnDefinition).ReadOnly = n.GetBoolValue(); } },
                {"required", (o,n) => { (o as ColumnDefinition).Required = n.GetBoolValue(); } },
                {"sourceColumn", (o,n) => { (o as ColumnDefinition).SourceColumn = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ColumnDefinition>(ApiSdk.Models.Microsoft.Graph.ColumnDefinition.CreateFromDiscriminatorValue); } },
                {"sourceContentType", (o,n) => { (o as ColumnDefinition).SourceContentType = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ContentTypeInfo>(ApiSdk.Models.Microsoft.Graph.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"term", (o,n) => { (o as ColumnDefinition).Term = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermColumn>(ApiSdk.Models.Microsoft.Graph.TermColumn.CreateFromDiscriminatorValue); } },
                {"text", (o,n) => { (o as ColumnDefinition).Text = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TextColumn>(ApiSdk.Models.Microsoft.Graph.TextColumn.CreateFromDiscriminatorValue); } },
                {"thumbnail", (o,n) => { (o as ColumnDefinition).Thumbnail = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ThumbnailColumn>(ApiSdk.Models.Microsoft.Graph.ThumbnailColumn.CreateFromDiscriminatorValue); } },
                {"type", (o,n) => { (o as ColumnDefinition).Type = n.GetEnumValue<ColumnTypes>(); } },
                {"validation", (o,n) => { (o as ColumnDefinition).Validation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ColumnValidation>(ApiSdk.Models.Microsoft.Graph.ColumnValidation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ContentApprovalStatusColumn>("contentApprovalStatus", ContentApprovalStatus);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.HyperlinkOrPictureColumn>("hyperlinkOrPicture", HyperlinkOrPicture);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteBoolValue("isDeletable", IsDeletable);
            writer.WriteBoolValue("isReorderable", IsReorderable);
            writer.WriteBoolValue("isSealed", IsSealed);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.NumberColumn>("number", Number);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ColumnDefinition>("sourceColumn", SourceColumn);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ContentTypeInfo>("sourceContentType", SourceContentType);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermColumn>("term", Term);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TextColumn>("text", Text);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ThumbnailColumn>("thumbnail", Thumbnail);
            writer.WriteEnumValue<ColumnTypes>("type", Type);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ColumnValidation>("validation", Validation);
        }
    }
}
