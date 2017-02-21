using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Gun-limit")]
	public class GunLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}