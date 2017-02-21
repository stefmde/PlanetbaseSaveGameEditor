using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "component-type")]
	public class ComponentType
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}