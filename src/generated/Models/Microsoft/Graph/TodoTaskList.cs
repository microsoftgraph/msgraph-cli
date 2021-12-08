using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TodoTaskList : Entity, IParsable {
        /// <summary>The name of the task list.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of open extensions defined for the task list. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>True if the user is owner of the given task list.</summary>
        public bool? IsOwner { get; set; }
        /// <summary>True if the task list is shared with other users</summary>
        public bool? IsShared { get; set; }
        /// <summary>The tasks in this task list. Read-only. Nullable.</summary>
        public List<TodoTask> Tasks { get; set; }
        /// <summary>Property indicating the list name if the given list is a well-known list. Possible values are: none, defaultList, flaggedEmails, unknownFutureValue.</summary>
        public WellknownListName? WellknownListName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as TodoTaskList).DisplayName = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as TodoTaskList).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"isOwner", (o,n) => { (o as TodoTaskList).IsOwner = n.GetBoolValue(); } },
                {"isShared", (o,n) => { (o as TodoTaskList).IsShared = n.GetBoolValue(); } },
                {"tasks", (o,n) => { (o as TodoTaskList).Tasks = n.GetCollectionOfObjectValues<TodoTask>().ToList(); } },
                {"wellknownListName", (o,n) => { (o as TodoTaskList).WellknownListName = n.GetEnumValue<WellknownListName>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("isOwner", IsOwner);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteCollectionOfObjectValues<TodoTask>("tasks", Tasks);
            writer.WriteEnumValue<WellknownListName>("wellknownListName", WellknownListName);
        }
    }
}
