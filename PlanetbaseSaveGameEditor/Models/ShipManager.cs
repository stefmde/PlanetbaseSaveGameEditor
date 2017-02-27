using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class ShipManager
	{
		public string Type { get; set; }


		public double TimeSinceLastColonistLanding { get; set; }

		public double TimeSinceLastVisitorLanding { get; set; }

		public double TimeSinceLastMerchantLanding { get; set; }

		public double TimeToNextIntruder { get; set; }

		public LandingPermissions LandingPermissions { get; set; }
	}
}