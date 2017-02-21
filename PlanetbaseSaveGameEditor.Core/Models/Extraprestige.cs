using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "extra-prestige")]
	public class ExtraPrestige
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}