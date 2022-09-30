using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class PrinterShare : PrinterBase, IParsable {
        /// <summary>If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.</summary>
        public bool? AllowAllUsers { get; set; }
        /// <summary>The groups whose users have access to print using the printer.</summary>
        public List<Group> AllowedGroups { get; set; }
        /// <summary>The users who have access to print using the printer.</summary>
        public List<User> AllowedUsers { get; set; }
        /// <summary>The DateTimeOffset when the printer share was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The printer that this printer share is related to.</summary>
        public ApiSdk.Models.Printer Printer { get; set; }
        /// <summary>
        /// Instantiates a new printerShare and sets the default values.
        /// </summary>
        public PrinterShare() : base() {
            OdataType = "#microsoft.graph.printerShare";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrinterShare CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterShare();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAllUsers", n => { AllowAllUsers = n.GetBoolValue(); } },
                {"allowedGroups", n => { AllowedGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"allowedUsers", n => { AllowedUsers = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"printer", n => { Printer = n.GetObjectValue<ApiSdk.Models.Printer>(ApiSdk.Models.Printer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAllUsers", AllowAllUsers);
            writer.WriteCollectionOfObjectValues<Group>("allowedGroups", AllowedGroups);
            writer.WriteCollectionOfObjectValues<User>("allowedUsers", AllowedUsers);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Printer>("printer", Printer);
        }
    }
}
