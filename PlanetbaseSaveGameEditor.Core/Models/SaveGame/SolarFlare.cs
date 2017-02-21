using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "solar-flare")]
	public class SolarFlare
	{
		[XmlElement(ElementName = "solar-flare-in-progress")]
		public SolarFlareInProgress SolarFlareInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-solar-flare")]
		public TimeToNextSolarflare TimeToNextSolarflare { get; set; }

		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }

		[XmlElement(ElementName = "solar-flare-time")]
		public SolarFlareTime SolarFlareTime { get; set; }
	}
}