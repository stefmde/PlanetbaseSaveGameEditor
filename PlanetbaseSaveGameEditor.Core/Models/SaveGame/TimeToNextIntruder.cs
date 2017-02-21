using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-to-next-intruder")]
	public class TimeToNextIntruder
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}