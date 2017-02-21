using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-to-next-sandstorm")]
	public class TimeToNextSandstorm
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}