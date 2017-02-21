using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "id-generator")]
	public class IdGenerator
	{
		[XmlElement(ElementName = "next-id")]
		public NextId Nextid { get; set; }
		[XmlElement(ElementName = "next-bot-id")]
		public NextbotId Nextbotid { get; set; }
	}
}