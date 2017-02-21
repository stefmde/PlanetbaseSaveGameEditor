using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "longitude")]
	public class Longitude
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}