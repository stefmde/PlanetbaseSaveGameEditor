using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "laser-charge")]
	public class LaserCharge
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}