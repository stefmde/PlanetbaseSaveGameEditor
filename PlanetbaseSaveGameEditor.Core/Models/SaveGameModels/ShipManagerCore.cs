using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "ship-manager")]
	public class ShipManagerCore
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "time-since-last-colonist-landing")]
		public ValueAttribute<Double> TimeSinceLastColonistLanding { get; set; }

		[XmlElement(ElementName = "time-since-last-visitor-landing")]
		public ValueAttribute<Double> TimeSinceLastVisitorLanding { get; set; }

		[XmlElement(ElementName = "time-since-last-merchant-landing")]
		public ValueAttribute<Double> TimeSinceLastMerchantLanding { get; set; }

		[XmlElement(ElementName = "time-to-next-intruder")]
		public ValueAttribute<Double> TimeToNextIntruder { get; set; }

		[XmlElement(ElementName = "landing-permissions")]
		public LandingPermissionsCore LandingPermissions { get; set; }
	}
}