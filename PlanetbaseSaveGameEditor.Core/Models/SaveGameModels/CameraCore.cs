using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "camera")]
	public class CameraCore
	{
		[XmlElement(ElementName = "height")]
		public ValueAttribute<Double> Height { get; set; }

		[XmlElement(ElementName = "position")]
		public CoordinatesCore Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public CoordinatesCore Orientation { get; set; }
	}
}