using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "landing-permissions")]
	public class LandingPermissions
	{
		[XmlElement(ElementName = "colonists-allowed")]
		public ColonistsAllowed ColonistsAllowed { get; set; }

		[XmlElement(ElementName = "merchants-allowed")]
		public MerchantsAllowed MerchantsAllowed { get; set; }

		[XmlElement(ElementName = "visitors-allowed")]
		public VisitorsAllowed VisitorsAllowed { get; set; }

		[XmlElement(ElementName = "Worker-percentage")]
		public WorkerPercentage WorkerPercentage { get; set; }

		[XmlElement(ElementName = "Biologist-percentage")]
		public BiologistPercentage BiologistPercentage { get; set; }

		[XmlElement(ElementName = "Engineer-percentage")]
		public EngineerPercentage EngineerPercentage { get; set; }

		[XmlElement(ElementName = "Medic-percentage")]
		public MedicPercentage MedicPercentage { get; set; }

		[XmlElement(ElementName = "Guard-percentage")]
		public GuardPercentage GuardPercentage { get; set; }
	}
}