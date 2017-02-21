using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "solar-flare-time")]
	public class SolarFlareTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}