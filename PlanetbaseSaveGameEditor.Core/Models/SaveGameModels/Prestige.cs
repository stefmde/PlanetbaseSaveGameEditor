using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "prestige")]
	public class Prestige
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}