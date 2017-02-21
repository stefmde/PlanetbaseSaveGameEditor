using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "fee")]
	public class Fee
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}