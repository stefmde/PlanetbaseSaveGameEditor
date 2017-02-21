using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "production-progress")]
	public class ProductionProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}