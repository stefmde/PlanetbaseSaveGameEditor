using System.Xml.Serialization;

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
		public InteractionPoint InteractionPoint { get; set; }

		[XmlElement(ElementName = "stage")]
		public Stage Stage { get; set; }

		[XmlElement(ElementName = "stage-progress")]
		public StageProgress StageProgress { get; set; }

		[XmlElement(ElementName = "target")]
		public Target Target { get; set; }
	}
}