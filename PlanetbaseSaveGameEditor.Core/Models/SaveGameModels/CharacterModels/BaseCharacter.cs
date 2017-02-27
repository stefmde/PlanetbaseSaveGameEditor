using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public abstract class BaseCharacter
	{
		[XmlAttribute(AttributeName = "type")]
		public CharacterType CharacterType { get; set; }

		[XmlElement(ElementName = "position")]
		public CoordinatesCore Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public CoordinatesCore Orientation { get; set; }

		[XmlElement(ElementName = "location")]
		public ValueAttribute<Int32> Location { get; set; }

		[XmlElement(ElementName = "name")]
		public ValueAttribute<String> Name { get; set; }

		[XmlElement(ElementName = "status-flags")]
		public ValueAttribute<String> StatusFlags { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Double> State { get; set; }

		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "wander-time")]
		public ValueAttribute<Double> WanderTime { get; set; }
	}
}
