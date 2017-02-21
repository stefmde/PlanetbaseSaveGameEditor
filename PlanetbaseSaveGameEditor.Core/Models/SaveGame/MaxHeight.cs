using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "max-height")]
	public class MaxHeight
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}