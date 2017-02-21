using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "sandstorm-time")]
	public class SandstormTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}