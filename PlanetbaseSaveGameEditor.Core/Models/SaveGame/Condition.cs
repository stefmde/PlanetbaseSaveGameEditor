using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "condition")]
	public class Condition
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}