using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "state-time")]
	public class StateTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}