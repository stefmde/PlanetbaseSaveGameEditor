using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "slot")]
	public class Slot
	{
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }

		[XmlElement(ElementName = "max-height")]
		public ValueAttribute<Double> MaxHeight { get; set; }

		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }
	}
}