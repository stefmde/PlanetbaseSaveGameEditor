using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "wander-time")]
	public class WanderTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}