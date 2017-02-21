using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "container-name")]
	public class ContainerName
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}