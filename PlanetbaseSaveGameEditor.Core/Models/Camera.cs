using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "camera")]
	public class Camera
	{
		[XmlElement(ElementName = "height")]
		public Height Height { get; set; }
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }
		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }
	}
}