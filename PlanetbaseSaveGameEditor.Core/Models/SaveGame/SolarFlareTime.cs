using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "solar-flare-time")]
	public class SolarFlareTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}