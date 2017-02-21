using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "size-index")]
	public class SizeIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}