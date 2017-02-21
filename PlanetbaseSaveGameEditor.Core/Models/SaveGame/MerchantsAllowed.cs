using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "merchants-allowed")]
	public class MerchantsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}