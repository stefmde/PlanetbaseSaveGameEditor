using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "manufacture-limits")]
	public class ManufactureLimits
	{
		[XmlElement(ElementName = "bot-limit")]
		public ValueAttribute<Int32> BotLimit { get; set; }

		[XmlElement(ElementName = "MedicalSupplies-limit")]
		public ValueAttribute<Int32> MedicalSuppliesLimit { get; set; }

		[XmlElement(ElementName = "Spares-limit")]
		public ValueAttribute<Int32> SparesLimit { get; set; }

		[XmlElement(ElementName = "Semiconductors-limit")]
		public ValueAttribute<Int32> SemiconductorsLimit { get; set; }

		[XmlElement(ElementName = "Gun-limit")]
		public ValueAttribute<Int32> GunLimit { get; set; }
	}
}