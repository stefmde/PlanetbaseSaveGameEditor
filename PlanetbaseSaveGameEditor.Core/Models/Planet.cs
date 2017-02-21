using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "planet")]
	public class Planet
	{
		[XmlElement(ElementName = "planet-index")]
		public PlanetIndex Planetindex { get; set; }
	}
}