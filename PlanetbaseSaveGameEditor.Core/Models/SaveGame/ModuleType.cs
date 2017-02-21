using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "module-type")]
	public class ModuleType
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}