using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "id-generator")]
	public class IdGenerator
	{
		[XmlElement(ElementName = "next-id")]
		public NextId NextId { get; set; }

		[XmlElement(ElementName = "next-bot-id")]
		public NextbotId NextBotId { get; set; }
	}
}