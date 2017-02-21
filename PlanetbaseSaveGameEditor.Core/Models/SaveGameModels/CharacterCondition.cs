using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Condition")]
	public class CharacterCondition
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}