using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Hydration")]
	public class Hydration
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}