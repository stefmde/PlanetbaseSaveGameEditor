using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-to-next-sandstorm")]
	public class TimeToNextSandstorm
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}