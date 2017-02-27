using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "colony")]
	public class ColonyCore
	{
		[XmlElement(ElementName = "extra-prestige")]
		public ValueAttribute<Int32> ExtraPrestige { get; set; }

		[XmlElement(ElementName = "game-time")]
		public ValueAttribute<Double> GameTime { get; set; }

		[XmlElement(ElementName = "real-game-time")]
		public ValueAttribute<Double> RealGameTime { get; set; }

		[XmlElement(ElementName = "name")]
		public ValueAttribute<String> Name { get; set; }

		[XmlElement(ElementName = "latitude")]
		public ValueAttribute<Int32> Latitude { get; set; }

		[XmlElement(ElementName = "longitude")]
		public ValueAttribute<Int32> Longitude { get; set; }
	}
}