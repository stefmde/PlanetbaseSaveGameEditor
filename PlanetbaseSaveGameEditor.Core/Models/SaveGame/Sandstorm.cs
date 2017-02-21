using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "sandstorm")]
	public class Sandstorm
	{
		[XmlElement(ElementName = "sandstorm-in-progress")]
		public SandstormInProgress SandstormInProgress { get; set; }

		[XmlElement(ElementName = "time-to-next-sandstorm")]
		public TimeToNextSandstorm TimeToNextSandstorm { get; set; }

		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }

		[XmlElement(ElementName = "sandstorm-time")]
		public SandstormTime SandstormTime { get; set; }
	}
}