using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "high-priority")]
	public class HighPriority
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}