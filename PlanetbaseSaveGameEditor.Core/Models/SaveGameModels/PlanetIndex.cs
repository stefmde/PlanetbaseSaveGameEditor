using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "planet-index")]
	public class PlanetIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}