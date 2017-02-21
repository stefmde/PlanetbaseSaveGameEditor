using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Guard-percentage")]
	public class GuardPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}