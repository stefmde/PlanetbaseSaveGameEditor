using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "meteor-manager")]
	public class MeteorManager
	{
		[XmlElement(ElementName = "seeds")]
		public MeteorSeeds MeteorSeeds { get; set; }
	}
}