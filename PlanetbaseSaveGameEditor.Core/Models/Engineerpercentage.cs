using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Engineer-percentage")]
	public class EngineerPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}