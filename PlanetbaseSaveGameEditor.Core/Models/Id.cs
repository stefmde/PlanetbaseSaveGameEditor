using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "id")]
	public class Id
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}