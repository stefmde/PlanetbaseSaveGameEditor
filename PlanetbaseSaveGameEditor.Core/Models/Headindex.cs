using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "head-index")]
	public class HeadIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}