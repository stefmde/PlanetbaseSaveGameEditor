using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "ship-manager")]
	public class ShipManager
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "time-since-last-colonist-landing")]
		public TimeSinceLastColonistLanding TimeSinceLastColonistLanding { get; set; }

		[XmlElement(ElementName = "time-since-last-visitor-landing")]
		public TimeSinceLastVisitorLanding TimeSinceLastVisitorLanding { get; set; }

		[XmlElement(ElementName = "time-since-last-merchant-landing")]
		public TimeSinceLastMerchantLanding TimeSinceLastMerchantLanding { get; set; }

		[XmlElement(ElementName = "time-to-next-intruder")]
		public TimeToNextIntruder TimeToNextIntruder { get; set; }

		[XmlElement(ElementName = "landing-permissions")]
		public LandingPermissions LandingPermissions { get; set; }
	}
}