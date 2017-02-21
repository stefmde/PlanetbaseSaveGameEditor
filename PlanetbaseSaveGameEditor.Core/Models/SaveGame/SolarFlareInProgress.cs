using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "solar-flare-in-progress")]
	public class SolarFlareInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}