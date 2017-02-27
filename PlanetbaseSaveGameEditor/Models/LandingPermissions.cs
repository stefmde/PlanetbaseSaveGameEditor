using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class LandingPermissions
	{
		public bool ColonistsAllowed { get; set; }

		public bool MerchantsAllowed { get; set; }

		public bool VisitorsAllowed { get; set; }


		public int WorkerPercentage { get; set; }

		public int BiologistPercentage { get; set; }

		public int EngineerPercentage { get; set; }

		public int MedicPercentage { get; set; }

		public int GuardPercentage { get; set; }
	}
}