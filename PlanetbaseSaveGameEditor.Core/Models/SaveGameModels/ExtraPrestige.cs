using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "extra-prestige")]
	public class ExtraPrestige
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}