using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "resources")]
	public class Resources
	{
		[XmlElement(ElementName = "inmaterial-resources")]
		public InmaterialResources Inmaterialresources { get; set; }
	}
}