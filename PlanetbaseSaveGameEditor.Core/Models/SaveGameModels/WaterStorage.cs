using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "water-storage")]
	public class WaterStorage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}