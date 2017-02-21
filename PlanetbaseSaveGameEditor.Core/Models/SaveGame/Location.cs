using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "location")]
	public class Location
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}