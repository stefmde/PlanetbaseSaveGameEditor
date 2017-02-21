using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Semiconductors-limit")]
	public class SemiconductorsLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}