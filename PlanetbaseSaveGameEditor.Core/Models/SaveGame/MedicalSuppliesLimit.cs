using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "MedicalSupplies-limit")]
	public class MedicalSuppliesLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}