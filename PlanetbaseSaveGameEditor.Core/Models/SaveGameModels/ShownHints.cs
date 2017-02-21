using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "shown-hints")]
	public class ShownHints
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}