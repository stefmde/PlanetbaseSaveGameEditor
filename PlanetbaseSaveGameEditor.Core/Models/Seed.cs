using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "seed")]
	public class Seed
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}