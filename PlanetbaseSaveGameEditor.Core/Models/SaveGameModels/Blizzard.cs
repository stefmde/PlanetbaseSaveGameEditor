using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "blizzard")]
	public class Blizzard
	{
		[XmlElement(ElementName = "blizzard-in-progress")]
		public BoolValueAttribute BlizzardInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-blizzard")]
		public ValueAttribute<Double> TimeToNextBlizzard { get; set; }

		[XmlElement(ElementName = "time")]
		public ValueAttribute<Double> Time { get; set; }

		[XmlElement(ElementName = "blizzard-time")]
		public ValueAttribute<Double> BlizzardTime { get; set; }
	}
}