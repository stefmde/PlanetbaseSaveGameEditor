using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "environment")]
	public class Environment
	{
		[XmlElement(ElementName = "time-of-day")]
		public TimeOfDay Timeofday { get; set; }
		[XmlElement(ElementName = "wind-indicator")]
		public WindIndicator Windindicator { get; set; }
	}
}