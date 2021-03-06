using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource")]
	public class ResourceCore
	{
		[XmlAttribute(AttributeName = "type")]
		public ResourceType Type { get; set; }


		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "trader-id")]
		public ValueAttribute<Int32> Traderid { get; set; }

		[XmlElement(ElementName = "position")]
		public CoordinatesCore Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public CoordinatesCore Orientation { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Int32> State { get; set; }

		[XmlElement(ElementName = "location")]
		public ValueAttribute<Int32> Location { get; set; }

		[XmlElement(ElementName = "subtype")]
		public ValueAttribute<Int32> Subtype { get; set; }

		[XmlElement(ElementName = "condition")]
		public ValueAttribute<Double> Condition { get; set; }

		[XmlElement(ElementName = "durability")]
		public ValueAttribute<Double> Durability { get; set; }
	}
}