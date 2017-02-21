using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "MedicalSupplies-limit")]
	public class MedicalSuppliesLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}