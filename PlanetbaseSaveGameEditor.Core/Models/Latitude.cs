using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "latitude")]
	public class Latitude
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}