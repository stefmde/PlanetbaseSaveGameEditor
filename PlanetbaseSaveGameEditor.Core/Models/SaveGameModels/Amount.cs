using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "amount")]
	public class Amount
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }

		[XmlElement(ElementName = "resource-type")]
		public ResourceType ResourceType { get; set; }

		[XmlElement(ElementName = "amount")]
		public Amount Amount2 { get; set; }
	}
}