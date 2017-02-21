using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "visitor-event-name")]
	public class VisitorEventName
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}