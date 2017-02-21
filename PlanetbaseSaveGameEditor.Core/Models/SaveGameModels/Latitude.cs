using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "latitude")]
	public class Latitude
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}