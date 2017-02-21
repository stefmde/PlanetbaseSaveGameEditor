using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "tech")]
	public class Tech
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}