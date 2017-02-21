using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "target-module")]
	public class TargetModule
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}