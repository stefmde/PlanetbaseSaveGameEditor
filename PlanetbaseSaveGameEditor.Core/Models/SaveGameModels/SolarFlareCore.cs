using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "solar-flare")]
	public class SolarFlareCore
	{
		[XmlElement(ElementName = "solar-flare-in-progress")]
		public BoolValueAttribute SolarFlareInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-solar-flare")]
		public ValueAttribute<Double> TimeToNextSolarflare { get; set; }

		[XmlElement(ElementName = "time")]
		public ValueAttribute<Double> Time { get; set; }

		[XmlElement(ElementName = "solar-flare-time")]
		public ValueAttribute<Double> SolarFlareTime { get; set; }
	}
}