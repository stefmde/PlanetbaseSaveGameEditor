using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Gun-limit")]
	public class GunLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}