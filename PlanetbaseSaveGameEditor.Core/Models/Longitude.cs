using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "longitude")]
	public class Longitude
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}