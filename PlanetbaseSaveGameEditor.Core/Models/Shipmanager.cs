using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "ship-manager")]
	public class Shipmanager
	{
		[XmlElement(ElementName = "time-since-last-colonist-landing")]
		public TimeSinceLastColonistLanding Timesincelastcolonistlanding { get; set; }
		[XmlElement(ElementName = "time-since-last-visitor-landing")]
		public TimeSinceLastVisitorLanding Timesincelastvisitorlanding { get; set; }
		[XmlElement(ElementName = "time-since-last-merchant-landing")]
		public TimeSinceLastMerchantLanding Timesincelastmerchantlanding { get; set; }
		[XmlElement(ElementName = "time-to-next-intruder")]
		public TimeToNextIntruder Timetonextintruder { get; set; }
		[XmlElement(ElementName = "landing-permissions")]
		public LandingPermissions Landingpermissions { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}