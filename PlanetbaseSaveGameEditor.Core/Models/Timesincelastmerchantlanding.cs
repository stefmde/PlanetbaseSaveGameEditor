using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-since-last-merchant-landing")]
	public class TimeSinceLastMerchantLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}