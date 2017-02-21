using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Sleep")]
	public class Sleep
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}