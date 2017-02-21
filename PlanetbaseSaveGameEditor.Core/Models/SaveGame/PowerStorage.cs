using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "power-storage")]
	public class PowerStorage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}