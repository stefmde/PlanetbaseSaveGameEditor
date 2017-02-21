using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "planet-index")]
	public class PlanetIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}