using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "interaction")]
	public class InteractionCore
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "character")]
		public InteractionCharacterCore InteractionCharacter { get; set; }

		[XmlElement(ElementName = "selectable")]
		public SelectableCore Selectable { get; set; }

		[XmlElement(ElementName = "interaction-point")]
		public ValueAttribute<String> InteractionPoint { get; set; }

		[XmlElement(ElementName = "stage")]
		public ValueAttribute<String> Stage { get; set; }

		[XmlElement(ElementName = "stage-progress")]
		public ValueAttribute<Double> StageProgress { get; set; }

		[XmlElement(ElementName = "target")]
		public CoordinatesCore Target { get; set; }
	}
}