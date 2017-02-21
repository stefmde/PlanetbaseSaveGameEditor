using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "specialization")]
	public class Specialization
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}