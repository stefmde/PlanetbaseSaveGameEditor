using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "time-to-next-solar-flare")]
	public class TimeToNextSolarflare
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}