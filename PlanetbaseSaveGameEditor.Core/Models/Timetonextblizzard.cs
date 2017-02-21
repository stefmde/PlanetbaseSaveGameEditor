using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-to-next-blizzard")]
	public class TimeToNextBlizzard
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}