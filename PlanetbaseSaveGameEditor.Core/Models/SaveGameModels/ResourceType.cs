using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource-type")]
	public class ResourceType
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}