using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "interaction-point")]
	public class InteractionPoint
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}