using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "id")]
	public class Id
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}