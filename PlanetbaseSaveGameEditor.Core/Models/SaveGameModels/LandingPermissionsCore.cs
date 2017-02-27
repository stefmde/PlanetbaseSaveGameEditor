using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "landing-permissions")]
	public class LandingPermissionsCore
	{
		[XmlElement(ElementName = "colonists-allowed")]
		public BoolValueAttribute ColonistsAllowed { get; set; }

		[XmlElement(ElementName = "merchants-allowed")]
		public BoolValueAttribute MerchantsAllowed { get; set; }

		[XmlElement(ElementName = "visitors-allowed")]
		public BoolValueAttribute VisitorsAllowed { get; set; }


		[XmlElement(ElementName = "Worker-percentage")]
		public ValueAttribute<Int32> WorkerPercentage { get; set; }

		[XmlElement(ElementName = "Biologist-percentage")]
		public ValueAttribute<Int32> BiologistPercentage { get; set; }

		[XmlElement(ElementName = "Engineer-percentage")]
		public ValueAttribute<Int32> EngineerPercentage { get; set; }

		[XmlElement(ElementName = "Medic-percentage")]
		public ValueAttribute<Int32> MedicPercentage { get; set; }

		[XmlElement(ElementName = "Guard-percentage")]
		public ValueAttribute<Int32> GuardPercentage { get; set; }
	}
}