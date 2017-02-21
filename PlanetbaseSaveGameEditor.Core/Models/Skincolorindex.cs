using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "skin-color-index")]
	public class SkinColorIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}