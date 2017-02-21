using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-since-last-visitor-landing")]
	public class TimeSinceLastVisitorLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}