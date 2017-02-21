using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "solar-flare-time")]
	public class SolarFlareTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}