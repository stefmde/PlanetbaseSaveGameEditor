using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "counts")]
	public class Counts
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}