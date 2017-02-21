using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Integrity")]
	public class Integrity
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}