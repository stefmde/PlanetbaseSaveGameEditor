using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "trader-id")]
	public class TraderId
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}