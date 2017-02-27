using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "visitor-events")]
	public class VisitorEventsCore
	{
		[XmlElement(ElementName = "next-event-time")]
		public ValueAttribute<Double> NextEventTime { get; set; }

		[XmlElement(ElementName = "visitor-event")]
		public VisitorEventCore VisitorEvent { get; set; }
	}
}