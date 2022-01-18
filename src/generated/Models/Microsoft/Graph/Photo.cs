using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Photo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Camera manufacturer. Read-only.</summary>
        public string CameraMake { get; set; }
        /// <summary>Camera model. Read-only.</summary>
        public string CameraModel { get; set; }
        /// <summary>The denominator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureDenominator { get; set; }
        /// <summary>The numerator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureNumerator { get; set; }
        /// <summary>The F-stop value from the camera. Read-only.</summary>
        public double? FNumber { get; set; }
        /// <summary>The focal length from the camera. Read-only.</summary>
        public double? FocalLength { get; set; }
        /// <summary>The ISO value from the camera. Read-only.</summary>
        public int? Iso { get; set; }
        /// <summary>The orientation value from the camera. Writable on OneDrive Personal.</summary>
        public int? Orientation { get; set; }
        /// <summary>The date and time the photo was taken in UTC time. Read-only.</summary>
        public DateTimeOffset? TakenDateTime { get; set; }
        /// <summary>
        /// Instantiates a new photo and sets the default values.
        /// </summary>
        public Photo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cameraMake", (o,n) => { (o as Photo).CameraMake = n.GetStringValue(); } },
                {"cameraModel", (o,n) => { (o as Photo).CameraModel = n.GetStringValue(); } },
                {"exposureDenominator", (o,n) => { (o as Photo).ExposureDenominator = n.GetDoubleValue(); } },
                {"exposureNumerator", (o,n) => { (o as Photo).ExposureNumerator = n.GetDoubleValue(); } },
                {"fNumber", (o,n) => { (o as Photo).FNumber = n.GetDoubleValue(); } },
                {"focalLength", (o,n) => { (o as Photo).FocalLength = n.GetDoubleValue(); } },
                {"iso", (o,n) => { (o as Photo).Iso = n.GetIntValue(); } },
                {"orientation", (o,n) => { (o as Photo).Orientation = n.GetIntValue(); } },
                {"takenDateTime", (o,n) => { (o as Photo).TakenDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cameraMake", CameraMake);
            writer.WriteStringValue("cameraModel", CameraModel);
            writer.WriteDoubleValue("exposureDenominator", ExposureDenominator);
            writer.WriteDoubleValue("exposureNumerator", ExposureNumerator);
            writer.WriteDoubleValue("fNumber", FNumber);
            writer.WriteDoubleValue("focalLength", FocalLength);
            writer.WriteIntValue("iso", Iso);
            writer.WriteIntValue("orientation", Orientation);
            writer.WriteDateTimeOffsetValue("takenDateTime", TakenDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
