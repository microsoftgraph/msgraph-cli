using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DirectoryObject1 : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AdministrativeUnit>? AdministrativeUnits { get; set; }
#nullable restore
#else
        public List<AdministrativeUnit> AdministrativeUnits { get; set; }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DeletedItems { get; set; }
#nullable restore
#else
        public List<DirectoryObject> DeletedItems { get; set; }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? FederationConfigurations { get; set; }
#nullable restore
#else
        public List<IdentityProviderBase> FederationConfigurations { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("federationConfigurations", FederationConfigurations);
        }
    }
}
