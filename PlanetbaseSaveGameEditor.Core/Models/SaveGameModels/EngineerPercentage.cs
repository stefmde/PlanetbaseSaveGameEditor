using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Engineer-percentage")]
	public class EngineerPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}