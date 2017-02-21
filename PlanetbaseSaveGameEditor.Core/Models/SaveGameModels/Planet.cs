using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "planet")]
	public class Planet
	{
		[XmlElement(ElementName = "planet-index")]
		public PlanetIndex PlanetIndex { get; set; }
	}
}