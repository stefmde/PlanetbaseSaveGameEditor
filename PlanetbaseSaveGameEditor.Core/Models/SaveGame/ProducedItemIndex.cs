using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "produced-item-index")]
	public class ProducedItemIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}