using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "subtype")]
	public class Subtype
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}