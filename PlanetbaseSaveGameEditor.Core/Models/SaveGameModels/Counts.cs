using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "counts")]
	public class Counts
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}