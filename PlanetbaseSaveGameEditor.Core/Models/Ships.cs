using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "ships")]
	public class Ships
	{
		[XmlElement(ElementName = "ship")]
		public Ship Ship { get; set; }
	}
}