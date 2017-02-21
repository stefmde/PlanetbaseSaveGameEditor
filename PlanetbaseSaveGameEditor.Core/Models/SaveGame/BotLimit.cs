using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "bot-limit")]
	public class BotLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}