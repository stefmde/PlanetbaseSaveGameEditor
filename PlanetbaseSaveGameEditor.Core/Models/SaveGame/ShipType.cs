using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "ship-type")]
	public class ShipType
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}