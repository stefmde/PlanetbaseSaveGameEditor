using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "visitor-event")]
	public class VisitorEvent
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "visitor-count")]
		public VisitorCount VisitorCount { get; set; }
	}
}