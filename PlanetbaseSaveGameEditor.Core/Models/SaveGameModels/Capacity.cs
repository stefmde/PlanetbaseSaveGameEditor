using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "capacity")]
	public class Capacity
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}