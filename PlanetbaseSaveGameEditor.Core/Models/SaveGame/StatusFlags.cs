using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "status-flags")]
	public class StatusFlags
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}