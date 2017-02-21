using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "time-built")]
	public class TimeBuilt
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}