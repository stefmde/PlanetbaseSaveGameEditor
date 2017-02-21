using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "blizzard-in-progress")]
	public class BlizzardInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}