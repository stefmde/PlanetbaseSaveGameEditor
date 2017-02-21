using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "time")]
	public class Time
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}