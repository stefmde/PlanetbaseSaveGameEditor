using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-since-last-merchant-landing")]
	public class TimeSinceLastMerchantLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}