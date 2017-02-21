using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "tech")]
	public class Tech
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}