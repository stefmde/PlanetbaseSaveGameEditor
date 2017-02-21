using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "landing-permissions")]
	public class LandingPermissions
	{
		[XmlElement(ElementName = "colonists-allowed")]
		public ColonistsAllowed Colonistsallowed { get; set; }
		[XmlElement(ElementName = "merchants-allowed")]
		public MerchantsAllowed Merchantsallowed { get; set; }
		[XmlElement(ElementName = "visitors-allowed")]
		public VisitorsAllowed Visitorsallowed { get; set; }
		[XmlElement(ElementName = "Worker-percentage")]
		public WorkerPercentage Workerpercentage { get; set; }
		[XmlElement(ElementName = "Biologist-percentage")]
		public BiologistPercentage Biologistpercentage { get; set; }
		[XmlElement(ElementName = "Engineer-percentage")]
		public EngineerPercentage Engineerpercentage { get; set; }
		[XmlElement(ElementName = "Medic-percentage")]
		public MedicPercentage Medicpercentage { get; set; }
		[XmlElement(ElementName = "Guard-percentage")]
		public GuardPercentage Guardpercentage { get; set; }
	}
}