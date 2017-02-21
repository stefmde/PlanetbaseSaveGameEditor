using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Oxygen")]
	public class Oxygen
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}