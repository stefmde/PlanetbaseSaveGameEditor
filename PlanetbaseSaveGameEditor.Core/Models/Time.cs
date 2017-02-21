using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time")]
	public class Time
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}