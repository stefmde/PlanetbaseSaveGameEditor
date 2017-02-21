using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "next-bot-id")]
	public class NextbotId
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}