using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "inmunity-to-contagion-time")]
	public class InmunityToContagionTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}