using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "locked")]
	public class Locked
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}