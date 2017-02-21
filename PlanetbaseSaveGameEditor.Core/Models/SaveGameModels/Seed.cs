using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "seed")]
	public class Seed
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}