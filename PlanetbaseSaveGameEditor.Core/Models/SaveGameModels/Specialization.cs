using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "specialization")]
	public class Specialization
	{
		[XmlAttribute(AttributeName = "value")]
		public SpecializationType Value { get; set; }
	}

	public enum SpecializationType
	{
		Unknown,
		Medic,
		Guard,
		Worker,
		Engineer,
		Biologist,
		Constructor,
		Driller,
		Carrier,
		Visitor
	}
}