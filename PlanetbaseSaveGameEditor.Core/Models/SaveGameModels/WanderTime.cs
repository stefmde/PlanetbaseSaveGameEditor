using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "wander-time")]
	public class WanderTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}