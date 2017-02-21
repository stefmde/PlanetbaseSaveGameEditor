using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Spares-limit")]
	public class SparesLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}