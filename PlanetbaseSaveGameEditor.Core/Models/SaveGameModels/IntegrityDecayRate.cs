using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "integrity-decay-rate")]
	public class IntegrityDecayRate
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}