using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "blizzard-time")]
	public class BlizzardTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}