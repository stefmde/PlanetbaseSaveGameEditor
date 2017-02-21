using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "capacity")]
	public class Capacity
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}