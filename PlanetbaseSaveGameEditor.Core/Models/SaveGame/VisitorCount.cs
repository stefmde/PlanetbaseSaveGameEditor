using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "visitor-count")]
	public class VisitorCount
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}