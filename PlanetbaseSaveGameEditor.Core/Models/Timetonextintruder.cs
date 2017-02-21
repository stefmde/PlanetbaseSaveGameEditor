using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-to-next-intruder")]
	public class TimeToNextIntruder
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}