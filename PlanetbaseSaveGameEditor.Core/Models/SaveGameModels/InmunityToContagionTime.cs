using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "inmunity-to-contagion-time")]
	public class InmunityToContagionTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}