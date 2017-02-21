using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "solar-flare-in-progress")]
	public class SolarFlareInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}