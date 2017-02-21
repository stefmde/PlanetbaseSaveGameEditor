using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "type-name")]
	public class TypeName
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}