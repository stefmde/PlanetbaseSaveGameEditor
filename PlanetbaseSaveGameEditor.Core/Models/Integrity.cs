using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Integrity")]
	public class Integrity
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}