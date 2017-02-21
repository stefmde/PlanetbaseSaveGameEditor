using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "time-since-last-colonist-landing")]
	public class TimeSinceLastColonistLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}