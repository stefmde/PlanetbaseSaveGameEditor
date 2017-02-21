using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "inmaterial-resources")]
	public class InmaterialResources
	{
		[XmlElement(ElementName = "container-name")]
		public ContainerName Containername { get; set; }

		[XmlElement(ElementName = "amount")]
		public Amount Amount { get; set; }
	}
}