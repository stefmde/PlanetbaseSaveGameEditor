using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "next-id")]
	public class NextId
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}