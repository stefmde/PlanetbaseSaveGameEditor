using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "enabled")]
	public class Enabled
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}