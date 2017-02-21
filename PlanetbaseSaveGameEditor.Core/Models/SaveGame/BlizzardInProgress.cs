using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "blizzard-in-progress")]
	public class BlizzardInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}