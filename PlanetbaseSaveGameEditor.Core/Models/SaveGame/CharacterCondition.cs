using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Condition")]
	public class CharacterCondition
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}