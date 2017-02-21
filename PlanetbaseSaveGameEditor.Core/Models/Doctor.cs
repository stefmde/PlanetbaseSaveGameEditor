using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "doctor")]
	public class Doctor
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}