using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "next-bot-id")]
	public class NextbotId
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}