using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "manufacture-limits")]
	public class ManufactureLimits
	{
		[XmlElement(ElementName = "bot-limit")]
		public BotLimit Botlimit { get; set; }
		[XmlElement(ElementName = "MedicalSupplies-limit")]
		public MedicalSuppliesLimit MedicalSupplieslimit { get; set; }
		[XmlElement(ElementName = "Spares-limit")]
		public SparesLimit Spareslimit { get; set; }
		[XmlElement(ElementName = "Semiconductors-limit")]
		public SemiconductorsLimit Semiconductorslimit { get; set; }
		[XmlElement(ElementName = "Gun-limit")]
		public GunLimit Gunlimit { get; set; }
	}
}