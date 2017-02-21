using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "height")]
	public class Height
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}