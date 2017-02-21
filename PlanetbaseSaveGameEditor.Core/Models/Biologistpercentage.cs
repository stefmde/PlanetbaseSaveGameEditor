using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Biologist-percentage")]
	public class BiologistPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}