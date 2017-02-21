using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "blizzard")]
	public class Blizzard
	{
		[XmlElement(ElementName = "blizzard-in-progress")]
		public BlizzardInProgress Blizzardinprogress { get; set; }
		[XmlElement(ElementName = "time-to-next-blizzard")]
		public TimeToNextBlizzard Timetonextblizzard { get; set; }
		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }
		[XmlElement(ElementName = "blizzard-time")]
		public BlizzardTime Blizzardtime { get; set; }
	}
}