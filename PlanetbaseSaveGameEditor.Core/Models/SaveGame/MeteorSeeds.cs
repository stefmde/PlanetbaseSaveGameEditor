using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "seeds")]
	public class MeteorSeeds
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}