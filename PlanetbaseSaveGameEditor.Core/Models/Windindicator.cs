using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "wind-indicator")]
	public class WindIndicator
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}