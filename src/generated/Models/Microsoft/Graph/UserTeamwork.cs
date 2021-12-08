using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserTeamwork : Entity, IParsable {
        /// <summary>The apps installed in the personal scope of this user.</summary>
        public List<UserScopeTeamsAppInstallation> InstalledApps { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"installedApps", (o,n) => { (o as UserTeamwork).InstalledApps = n.GetCollectionOfObjectValues<UserScopeTeamsAppInstallation>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserScopeTeamsAppInstallation>("installedApps", InstalledApps);
        }
    }
}
