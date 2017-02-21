using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "selectable")]
	public class Selectable
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "type-name")]
		public string Typename { get; set; }
	}
}