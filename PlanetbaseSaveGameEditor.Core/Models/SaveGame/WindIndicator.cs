using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "wind-indicator")]
	public class WindIndicator
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}