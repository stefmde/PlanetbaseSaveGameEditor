using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "inmaterial-resources")]
	public class InmaterialResources
	{
		[XmlElement(ElementName = "container-name")]
		public ContainerName Containername { get; set; }
	}
}