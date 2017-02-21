using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "ship")]
	public class Ship
	{
		[XmlElement(ElementName = "id")]
		public Id Id { get; set; }
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }
		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }
		[XmlElement(ElementName = "target-position")]
		public TargetPosition Targetposition { get; set; }
		[XmlElement(ElementName = "state")]
		public State State { get; set; }
		[XmlElement(ElementName = "resource-container")]
		public ResourCecontainer Resourcecontainer { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}