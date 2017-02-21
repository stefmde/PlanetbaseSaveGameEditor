using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "gender")]
	public class Gender
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}