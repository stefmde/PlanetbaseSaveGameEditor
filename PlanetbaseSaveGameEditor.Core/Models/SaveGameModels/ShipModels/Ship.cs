using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.ShipModels
{
	[XmlRoot(ElementName = "ship")]
	public class Ship
	{
		[XmlAttribute(AttributeName = "type")]
		public ShipType Type { get; set; }


		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "position")]
		public CoordinatesCore Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public CoordinatesCore Orientation { get; set; }

		[XmlElement(ElementName = "state-time")]
		public ValueAttribute<Double> StateTime { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Double> State { get; set; }

		[XmlElement(ElementName = "target-module")]
		public ValueAttribute<Int32> TargetModule { get; set; }

		[XmlElement(ElementName = "original-rotation")]
		public CoordinatesCore OriginalRotation { get; set; }

		[XmlElement(ElementName = "final-rotation")]
		public CoordinatesCore FinalRotation { get; set; }

		[XmlElement(ElementName = "size")]
		public ValueAttribute<Int32> Size { get; set; }

		[XmlElement(ElementName = "intruders")]
		public BoolValueAttribute Intruders { get; set; }

		[XmlElement(ElementName = "velocity")]
		public CoordinatesCore Velocity { get; set; }

		[XmlElement(ElementName = "visitor-event-name")]
		public ValueAttribute<String> Visitoreventname { get; set; }

		[XmlElement(ElementName = "ship-type")]
		public ValueAttribute<Int32> ShipType { get; set; }

		[XmlElement(ElementName = "pending-visitors")]
		public ValueAttribute<Int32> PendingVisitors { get; set; }

		[XmlElement(ElementName = "fee")]
		public ValueAttribute<Int32> Fee { get; set; }

		[XmlElement(ElementName = "prestige")]
		public ValueAttribute<Int32> Prestige { get; set; }
	}
}