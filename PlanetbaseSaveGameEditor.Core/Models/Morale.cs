using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Morale")]
	public class Morale
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}