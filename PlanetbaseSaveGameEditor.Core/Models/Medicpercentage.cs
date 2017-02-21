using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Medic-percentage")]
	public class MedicPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}