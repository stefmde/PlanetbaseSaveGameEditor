using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "skin-color-index")]
	public class SkinColorIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}