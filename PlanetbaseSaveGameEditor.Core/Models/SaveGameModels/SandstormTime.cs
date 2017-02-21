using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "sandstorm-time")]
	public class SandstormTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}