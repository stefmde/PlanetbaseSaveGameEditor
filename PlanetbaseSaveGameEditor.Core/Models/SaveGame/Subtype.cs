using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "subtype")]
	public class Subtype
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}