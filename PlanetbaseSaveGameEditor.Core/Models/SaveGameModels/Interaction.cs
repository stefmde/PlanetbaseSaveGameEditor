using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "interaction")]
	public class Interaction
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "character")]
		public InteractionCharacter InteractionCharacter { get; set; }

		[XmlElement(ElementName = "selectable")]
		public Selectable Selectable { get; set; }

		[XmlElement(ElementName = "interaction-point")]
		public ValueAttribute<String> InteractionPoint { get; set; }

		[XmlElement(ElementName = "stage")]
		public ValueAttribute<String> Stage { get; set; }

		[XmlElement(ElementName = "stage-progress")]
		public ValueAttribute<Double> StageProgress { get; set; }

		[XmlElement(ElementName = "target")]
		public Coordinates Target { get; set; }
	}
}