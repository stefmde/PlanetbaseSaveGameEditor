using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Biologist-percentage")]
	public class BiologistPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}