using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "location")]
	public class Location
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}