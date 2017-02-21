using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "resource")]
	public class Resource
	{
		[XmlElement(ElementName = "id")]
		public Id Id { get; set; }
		[XmlElement(ElementName = "trader-id")]
		public TraderId Traderid { get; set; }
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }
		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }
		[XmlElement(ElementName = "state")]
		public State State { get; set; }
		[XmlElement(ElementName = "location")]
		public Location Location { get; set; }
		[XmlElement(ElementName = "subtype")]
		public Subtype Subtype { get; set; }
		[XmlElement(ElementName = "condition")]
		public Condition Condition { get; set; }
		[XmlElement(ElementName = "durability")]
		public Durability Durability { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}