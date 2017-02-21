using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "blizzard-time")]
	public class BlizzardTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}