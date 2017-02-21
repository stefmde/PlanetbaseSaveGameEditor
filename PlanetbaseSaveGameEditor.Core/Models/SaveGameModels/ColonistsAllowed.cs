using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "colonists-allowed")]
	public class ColonistsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}