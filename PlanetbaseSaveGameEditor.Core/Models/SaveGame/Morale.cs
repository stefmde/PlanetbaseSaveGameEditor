using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Morale")]
	public class Morale
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}