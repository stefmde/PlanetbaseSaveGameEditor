using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "next-event-time")]
	public class NextEventTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}