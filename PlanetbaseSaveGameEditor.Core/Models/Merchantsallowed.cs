using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "merchants-allowed")]
	public class MerchantsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}