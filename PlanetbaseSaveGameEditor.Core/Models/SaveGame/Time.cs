using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time")]
	public class Time
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}