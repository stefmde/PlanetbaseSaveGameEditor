using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Oxygen")]
	public class Oxygen
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}