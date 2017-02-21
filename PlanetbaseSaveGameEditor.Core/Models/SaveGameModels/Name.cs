using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "name")]
	public class Name
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}