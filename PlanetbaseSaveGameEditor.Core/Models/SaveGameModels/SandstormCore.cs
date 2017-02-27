using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "sandstorm")]
	public class SandstormCore
	{
		[XmlElement(ElementName = "sandstorm-in-progress")]
		public BoolValueAttribute SandstormInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-sandstorm")]
		public ValueAttribute<Double> TimeToNextSandstorm { get; set; }

		[XmlElement(ElementName = "time")]
		public ValueAttribute<Double> Time { get; set; }

		[XmlElement(ElementName = "sandstorm-time")]
		public ValueAttribute<Double> SandstormTime { get; set; }
	}
}