using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "sandstorm")]
	public class Sandstorm
	{
		[XmlElement(ElementName = "sandstorm-in-progress")]
		public SandstormInProgress Sandstorminprogress { get; set; }
		[XmlElement(ElementName = "time-to-next-sandstorm")]
		public TimeToNextSandstorm Timetonextsandstorm { get; set; }
		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }
		[XmlElement(ElementName = "sandstorm-time")]
		public SandstormTime Sandstormtime { get; set; }
	}
}