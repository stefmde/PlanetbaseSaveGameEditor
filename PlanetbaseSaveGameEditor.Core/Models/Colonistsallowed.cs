using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "colonists-allowed")]
	public class ColonistsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}