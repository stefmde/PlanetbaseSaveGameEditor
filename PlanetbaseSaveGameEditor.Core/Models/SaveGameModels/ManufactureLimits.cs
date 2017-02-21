using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "manufacture-limits")]
	public class ManufactureLimits
	{
		[XmlElement(ElementName = "bot-limit")]
		public BotLimit BotLimit { get; set; }

		[XmlElement(ElementName = "MedicalSupplies-limit")]
		public MedicalSuppliesLimit MedicalSuppliesLimit { get; set; }

		[XmlElement(ElementName = "Spares-limit")]
		public SparesLimit SparesLimit { get; set; }

		[XmlElement(ElementName = "Semiconductors-limit")]
		public SemiconductorsLimit SemiconductorsLimit { get; set; }

		[XmlElement(ElementName = "Gun-limit")]
		public GunLimit GunLimit { get; set; }
	}
}