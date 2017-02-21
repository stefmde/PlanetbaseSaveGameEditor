using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Nutrition")]
	public class Nutrition
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}