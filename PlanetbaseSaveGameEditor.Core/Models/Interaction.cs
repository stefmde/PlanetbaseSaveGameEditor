using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGame;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "interaction")]
	public class Interaction
	{
		[XmlElement(ElementName = "character")]
		public Character Character { get; set; }

		[XmlElement(ElementName = "selectable")]
		public Selectable Selectable { get; set; }

		[XmlElement(ElementName = "interaction-point")]
		public InteractionPoint InteractionPoint { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlElement(ElementName = "stage")]
		public Stage Stage { get; set; }

		[XmlElement(ElementName = "stage-progress")]
		public StageProgress StageProgress { get; set; }

		[XmlElement(ElementName = "target")]
		public Target Target { get; set; }
	}
}