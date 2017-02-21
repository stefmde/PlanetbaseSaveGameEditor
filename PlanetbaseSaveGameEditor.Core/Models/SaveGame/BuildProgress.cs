using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "build-progress")]
	public class BuildProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}