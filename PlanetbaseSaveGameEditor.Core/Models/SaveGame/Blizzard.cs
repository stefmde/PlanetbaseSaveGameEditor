using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "blizzard")]
	public class Blizzard
	{
		[XmlElement(ElementName = "blizzard-in-progress")]
		public BlizzardInProgress BlizzardInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-blizzard")]
		public TimeToNextBlizzard TimeToNextBlizzard { get; set; }

		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }

		[XmlElement(ElementName = "blizzard-time")]
		public BlizzardTime BlizzardTime { get; set; }
	}
}