using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "environment")]
	public class EnvironmentCore
	{
		[XmlElement(ElementName = "time-of-day")]
		public ValueAttribute<Double> TimeOfDay { get; set; }

		[XmlElement(ElementName = "wind-indicator")]
		public ValueAttribute<Double> WindIndicator { get; set; }
	}
}