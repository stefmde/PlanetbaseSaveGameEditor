using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "next-id")]
	public class NextId
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}