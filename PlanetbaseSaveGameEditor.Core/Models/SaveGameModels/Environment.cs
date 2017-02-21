using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "environment")]
	public class Environment
	{
		[XmlElement(ElementName = "time-of-day")]
		public TimeOfDay TimeOfDay { get; set; }

		[XmlElement(ElementName = "wind-indicator")]
		public WindIndicator WindIndicator { get; set; }
	}
}