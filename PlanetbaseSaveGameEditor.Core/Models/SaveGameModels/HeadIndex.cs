using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "head-index")]
	public class HeadIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}