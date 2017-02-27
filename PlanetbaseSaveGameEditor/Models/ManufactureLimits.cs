using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class ManufactureLimits
	{
		public int BotLimit { get; set; }

		public int MedicalSuppliesLimit { get; set; }

		public int SparesLimit { get; set; }

		public int SemiconductorsLimit { get; set; }

		public int GunLimit { get; set; }
	}
}