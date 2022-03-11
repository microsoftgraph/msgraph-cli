using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DriveItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Only on OneDrive Personal.</summary>
        public ApiSdk.Models.Microsoft.Graph.Audio Audio { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Bundle Bundle { get; set; }
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
        public List<DriveItem> Children { get; set; }
        /// <summary>The content stream, if the item represents a file.</summary>
        public byte[] Content { get; set; }
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
        public string CTag { get; set; }
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Deleted Deleted { get; set; }
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.File File { get; set; }
        /// <summary>File system information on client. Read-write.</summary>
        public ApiSdk.Models.Microsoft.Graph.FileSystemInfo FileSystemInfo { get; set; }
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Folder Folder { get; set; }
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Image Image { get; set; }
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.ListItem ListItem { get; set; }
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
        public GeoCoordinates Location { get; set; }
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Malware Malware { get; set; }
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Package Package { get; set; }
        /// <summary>If present, indicates that indicates that one or more operations that may affect the state of the driveItem are pending completion. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.PendingOperations PendingOperations { get; set; }
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
        public List<Permission> Permissions { get; set; }
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Photo Photo { get; set; }
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
        public PublicationFacet Publication { get; set; }
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.RemoteItem RemoteItem { get; set; }
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
        public ApiSdk.Models.Microsoft.Graph.Root Root { get; set; }
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SearchResult SearchResult { get; set; }
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Shared Shared { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SpecialFolder SpecialFolder { get; set; }
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
        public List<Subscription> Subscriptions { get; set; }
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
        public List<ThumbnailSet> Thumbnails { get; set; }
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
        public List<DriveItemVersion> Versions { get; set; }
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Video Video { get; set; }
        /// <summary>WebDAV compatible URL for the item.</summary>
        public string WebDavUrl { get; set; }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.Workbook Workbook { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"analytics", (o,n) => { (o as DriveItem).Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", (o,n) => { (o as DriveItem).Audio = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Audio>(ApiSdk.Models.Microsoft.Graph.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", (o,n) => { (o as DriveItem).Bundle = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Bundle>(ApiSdk.Models.Microsoft.Graph.Bundle.CreateFromDiscriminatorValue); } },
                {"children", (o,n) => { (o as DriveItem).Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"content", (o,n) => { (o as DriveItem).Content = n.GetByteArrayValue(); } },
                {"cTag", (o,n) => { (o as DriveItem).CTag = n.GetStringValue(); } },
                {"deleted", (o,n) => { (o as DriveItem).Deleted = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Deleted>(ApiSdk.Models.Microsoft.Graph.Deleted.CreateFromDiscriminatorValue); } },
                {"file", (o,n) => { (o as DriveItem).File = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.File>(ApiSdk.Models.Microsoft.Graph.File.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", (o,n) => { (o as DriveItem).FileSystemInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.FileSystemInfo>(ApiSdk.Models.Microsoft.Graph.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", (o,n) => { (o as DriveItem).Folder = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Folder>(ApiSdk.Models.Microsoft.Graph.Folder.CreateFromDiscriminatorValue); } },
                {"image", (o,n) => { (o as DriveItem).Image = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Image>(ApiSdk.Models.Microsoft.Graph.Image.CreateFromDiscriminatorValue); } },
                {"listItem", (o,n) => { (o as DriveItem).ListItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ListItem>(ApiSdk.Models.Microsoft.Graph.ListItem.CreateFromDiscriminatorValue); } },
                {"location", (o,n) => { (o as DriveItem).Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", (o,n) => { (o as DriveItem).Malware = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Malware>(ApiSdk.Models.Microsoft.Graph.Malware.CreateFromDiscriminatorValue); } },
                {"package", (o,n) => { (o as DriveItem).Package = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Package>(ApiSdk.Models.Microsoft.Graph.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", (o,n) => { (o as DriveItem).PendingOperations = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PendingOperations>(ApiSdk.Models.Microsoft.Graph.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", (o,n) => { (o as DriveItem).Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", (o,n) => { (o as DriveItem).Photo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Photo>(ApiSdk.Models.Microsoft.Graph.Photo.CreateFromDiscriminatorValue); } },
                {"publication", (o,n) => { (o as DriveItem).Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", (o,n) => { (o as DriveItem).RemoteItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RemoteItem>(ApiSdk.Models.Microsoft.Graph.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", (o,n) => { (o as DriveItem).Root = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Root>(ApiSdk.Models.Microsoft.Graph.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", (o,n) => { (o as DriveItem).SearchResult = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SearchResult>(ApiSdk.Models.Microsoft.Graph.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", (o,n) => { (o as DriveItem).Shared = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Shared>(ApiSdk.Models.Microsoft.Graph.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as DriveItem).SharepointIds = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>(ApiSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", (o,n) => { (o as DriveItem).Size = n.GetLongValue(); } },
                {"specialFolder", (o,n) => { (o as DriveItem).SpecialFolder = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SpecialFolder>(ApiSdk.Models.Microsoft.Graph.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", (o,n) => { (o as DriveItem).Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue).ToList(); } },
                {"thumbnails", (o,n) => { (o as DriveItem).Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue).ToList(); } },
                {"versions", (o,n) => { (o as DriveItem).Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"video", (o,n) => { (o as DriveItem).Video = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Video>(ApiSdk.Models.Microsoft.Graph.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", (o,n) => { (o as DriveItem).WebDavUrl = n.GetStringValue(); } },
                {"workbook", (o,n) => { (o as DriveItem).Workbook = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Workbook>(ApiSdk.Models.Microsoft.Graph.Workbook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Audio>("audio", Audio);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.File>("file", File);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Folder>("folder", Folder);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Image>("image", Image);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Malware>("malware", Malware);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Package>("package", Package);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Root>("root", Root);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Shared>("shared", Shared);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Workbook>("workbook", Workbook);
        }
    }
}
