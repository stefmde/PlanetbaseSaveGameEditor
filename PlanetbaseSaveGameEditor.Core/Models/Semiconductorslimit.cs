using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Semiconductors-limit")]
	public class SemiconductorsLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}