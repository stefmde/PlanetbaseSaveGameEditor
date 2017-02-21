using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-of-day")]
	public class TimeOfDay
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}