using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "sandstorm-in-progress")]
	public class SandstormInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}