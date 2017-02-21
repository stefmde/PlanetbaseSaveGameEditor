using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Medic-percentage")]
	public class MedicPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}