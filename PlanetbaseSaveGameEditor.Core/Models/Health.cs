using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Health")]
	public class Health
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}