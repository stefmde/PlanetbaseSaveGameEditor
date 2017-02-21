using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "stage")]
	public class Stage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}