using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "size")]
	public class Size
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}