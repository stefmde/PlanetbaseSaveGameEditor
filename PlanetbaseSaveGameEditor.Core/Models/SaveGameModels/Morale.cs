using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Morale")]
	public class Morale
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}