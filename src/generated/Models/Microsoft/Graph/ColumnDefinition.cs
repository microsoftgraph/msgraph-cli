using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ColumnDefinition : Entity, IParsable {
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? @ReadOnly { get; set; }
        /// <summary>This column stores boolean values.</summary>
        public BooleanColumn Boolean { get; set; }
        /// <summary>This column's data is calculated based on other columns.</summary>
        public CalculatedColumn Calculated { get; set; }
        /// <summary>This column stores data from a list of choices.</summary>
        public ChoiceColumn Choice { get; set; }
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
        public string ColumnGroup { get; set; }
        /// <summary>This column stores content approval status.</summary>
        public ContentApprovalStatusColumn ContentApprovalStatus { get; set; }
        /// <summary>This column stores currency values.</summary>
        public CurrencyColumn Currency { get; set; }
        /// <summary>This column stores DateTime values.</summary>
        public DateTimeColumn DateTime { get; set; }
        /// <summary>The default value for this column.</summary>
        public DefaultColumnValue DefaultValue { get; set; }
        /// <summary>The user-facing description of the column.</summary>
        public string Description { get; set; }
        /// <summary>The user-facing name of the column.</summary>
        public string DisplayName { get; set; }
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues { get; set; }
        /// <summary>This column stores a geolocation.</summary>
        public GeolocationColumn Geolocation { get; set; }
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden { get; set; }
        /// <summary>This column stores hyperlink or picture values.</summary>
        public HyperlinkOrPictureColumn HyperlinkOrPicture { get; set; }
        /// <summary>Specifies whether the column values can used for sorting and searching.</summary>
        public bool? Indexed { get; set; }
        /// <summary>Indicates whether this column can be deleted.</summary>
        public bool? IsDeletable { get; set; }
        /// <summary>Indicates whether values in the column can be reordered. Read-only.</summary>
        public bool? IsReorderable { get; set; }
        /// <summary>Specifies whether the column can be changed.</summary>
        public bool? IsSealed { get; set; }
        /// <summary>This column's data is looked up from another source in the site.</summary>
        public LookupColumn Lookup { get; set; }
        /// <summary>The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.</summary>
        public string Name { get; set; }
        /// <summary>This column stores number values.</summary>
        public NumberColumn Number { get; set; }
        /// <summary>This column stores Person or Group values.</summary>
        public PersonOrGroupColumn PersonOrGroup { get; set; }
        /// <summary>If true, changes to this column will be propagated to lists that implement the column.</summary>
        public bool? PropagateChanges { get; set; }
        /// <summary>Specifies whether the column value isn't optional.</summary>
        public bool? Required { get; set; }
        /// <summary>The source column for content type column.</summary>
        public ColumnDefinition SourceColumn { get; set; }
        /// <summary>This column stores taxonomy terms.</summary>
        public TermColumn Term { get; set; }
        /// <summary>This column stores text values.</summary>
        public TextColumn Text { get; set; }
        /// <summary>This column stores thumbnail values.</summary>
        public ThumbnailColumn Thumbnail { get; set; }
        /// <summary>For site columns, the type of column. Read-only.</summary>
        public ColumnTypes? Type { get; set; }
        /// <summary>This column stores validation formula and message for the column.</summary>
        public ColumnValidation Validation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"@ReadOnly", (o,n) => { (o as ColumnDefinition).@ReadOnly = n.GetBoolValue(); } },
                {"boolean", (o,n) => { (o as ColumnDefinition).Boolean = n.GetObjectValue<BooleanColumn>(); } },
                {"calculated", (o,n) => { (o as ColumnDefinition).Calculated = n.GetObjectValue<CalculatedColumn>(); } },
                {"choice", (o,n) => { (o as ColumnDefinition).Choice = n.GetObjectValue<ChoiceColumn>(); } },
                {"columnGroup", (o,n) => { (o as ColumnDefinition).ColumnGroup = n.GetStringValue(); } },
                {"contentApprovalStatus", (o,n) => { (o as ColumnDefinition).ContentApprovalStatus = n.GetObjectValue<ContentApprovalStatusColumn>(); } },
                {"currency", (o,n) => { (o as ColumnDefinition).Currency = n.GetObjectValue<CurrencyColumn>(); } },
                {"dateTime", (o,n) => { (o as ColumnDefinition).DateTime = n.GetObjectValue<DateTimeColumn>(); } },
                {"defaultValue", (o,n) => { (o as ColumnDefinition).DefaultValue = n.GetObjectValue<DefaultColumnValue>(); } },
                {"description", (o,n) => { (o as ColumnDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ColumnDefinition).DisplayName = n.GetStringValue(); } },
                {"enforceUniqueValues", (o,n) => { (o as ColumnDefinition).EnforceUniqueValues = n.GetBoolValue(); } },
                {"geolocation", (o,n) => { (o as ColumnDefinition).Geolocation = n.GetObjectValue<GeolocationColumn>(); } },
                {"hidden", (o,n) => { (o as ColumnDefinition).Hidden = n.GetBoolValue(); } },
                {"hyperlinkOrPicture", (o,n) => { (o as ColumnDefinition).HyperlinkOrPicture = n.GetObjectValue<HyperlinkOrPictureColumn>(); } },
                {"indexed", (o,n) => { (o as ColumnDefinition).Indexed = n.GetBoolValue(); } },
                {"isDeletable", (o,n) => { (o as ColumnDefinition).IsDeletable = n.GetBoolValue(); } },
                {"isReorderable", (o,n) => { (o as ColumnDefinition).IsReorderable = n.GetBoolValue(); } },
                {"isSealed", (o,n) => { (o as ColumnDefinition).IsSealed = n.GetBoolValue(); } },
                {"lookup", (o,n) => { (o as ColumnDefinition).Lookup = n.GetObjectValue<LookupColumn>(); } },
                {"name", (o,n) => { (o as ColumnDefinition).Name = n.GetStringValue(); } },
                {"number", (o,n) => { (o as ColumnDefinition).Number = n.GetObjectValue<NumberColumn>(); } },
                {"personOrGroup", (o,n) => { (o as ColumnDefinition).PersonOrGroup = n.GetObjectValue<PersonOrGroupColumn>(); } },
                {"propagateChanges", (o,n) => { (o as ColumnDefinition).PropagateChanges = n.GetBoolValue(); } },
                {"required", (o,n) => { (o as ColumnDefinition).Required = n.GetBoolValue(); } },
                {"sourceColumn", (o,n) => { (o as ColumnDefinition).SourceColumn = n.GetObjectValue<ColumnDefinition>(); } },
                {"term", (o,n) => { (o as ColumnDefinition).Term = n.GetObjectValue<TermColumn>(); } },
                {"text", (o,n) => { (o as ColumnDefinition).Text = n.GetObjectValue<TextColumn>(); } },
                {"thumbnail", (o,n) => { (o as ColumnDefinition).Thumbnail = n.GetObjectValue<ThumbnailColumn>(); } },
                {"type", (o,n) => { (o as ColumnDefinition).Type = n.GetEnumValue<ColumnTypes>(); } },
                {"validation", (o,n) => { (o as ColumnDefinition).Validation = n.GetObjectValue<ColumnValidation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("@ReadOnly", @ReadOnly);
            writer.WriteObjectValue<BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<ContentApprovalStatusColumn>("contentApprovalStatus", ContentApprovalStatus);
            writer.WriteObjectValue<CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<HyperlinkOrPictureColumn>("hyperlinkOrPicture", HyperlinkOrPicture);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteBoolValue("isDeletable", IsDeletable);
            writer.WriteBoolValue("isReorderable", IsReorderable);
            writer.WriteBoolValue("isSealed", IsSealed);
            writer.WriteObjectValue<LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<NumberColumn>("number", Number);
            writer.WriteObjectValue<PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<ColumnDefinition>("sourceColumn", SourceColumn);
            writer.WriteObjectValue<TermColumn>("term", Term);
            writer.WriteObjectValue<TextColumn>("text", Text);
            writer.WriteObjectValue<ThumbnailColumn>("thumbnail", Thumbnail);
            writer.WriteEnumValue<ColumnTypes>("type", Type);
            writer.WriteObjectValue<ColumnValidation>("validation", Validation);
        }
    }
}
