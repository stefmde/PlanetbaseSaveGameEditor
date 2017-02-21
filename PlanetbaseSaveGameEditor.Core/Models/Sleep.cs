using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Sleep")]
	public class Sleep
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}