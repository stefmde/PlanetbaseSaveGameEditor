using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "intruders")]
	public class Intruders
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}