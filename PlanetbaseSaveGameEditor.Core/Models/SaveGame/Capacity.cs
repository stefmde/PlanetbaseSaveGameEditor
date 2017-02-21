using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "capacity")]
	public class Capacity
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}