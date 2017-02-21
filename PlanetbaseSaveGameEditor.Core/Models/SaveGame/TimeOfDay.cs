using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-of-day")]
	public class TimeOfDay
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}