using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "blizzard-in-progress")]
	public class BlizzardInProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}