using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "gender")]
	public class Gender
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}