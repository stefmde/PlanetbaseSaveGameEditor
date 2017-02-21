using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "trader-id")]
	public class TraderId
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}