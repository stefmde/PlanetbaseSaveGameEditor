using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "integrity-decay-rate")]
	public class IntegrityDecayRate
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}