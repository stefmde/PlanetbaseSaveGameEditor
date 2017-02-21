using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "agression-time")]
	public class AgressionTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}