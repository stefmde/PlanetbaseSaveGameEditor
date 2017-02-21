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

		[XmlElement(ElementName = "state-time")]
		public StateTime StateTime { get; set; }

		[XmlElement(ElementName = "state")]
		public State State { get; set; }

		[XmlElement(ElementName = "target-module")]
		public TargetModule TargetModule { get; set; }

		[XmlElement(ElementName = "original-rotation")]
		public OriginalRotation OriginalRotation { get; set; }

		[XmlElement(ElementName = "final-rotation")]
		public FinalRotation FinalRotation { get; set; }

		[XmlElement(ElementName = "size")]
		public Size Size { get; set; }

		[XmlElement(ElementName = "intruders")]
		public Intruders Intruders { get; set; }

		[XmlElement(ElementName = "velocity")]
		public Velocity Velocity { get; set; }

		[XmlElement(ElementName = "visitor-event-name")]
		public VisitorEventName Visitoreventname { get; set; }

		[XmlElement(ElementName = "ship-type")]
		public ShipType ShipType { get; set; }

		[XmlElement(ElementName = "pending-visitors")]
		public PendingVisitors PendingVisitors { get; set; }

		[XmlElement(ElementName = "fee")]
		public Fee Fee { get; set; }

		[XmlElement(ElementName = "prestige")]
		public Prestige Prestige { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}