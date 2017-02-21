using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "sandstorm-in-progress")]
	public class SandstormInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}