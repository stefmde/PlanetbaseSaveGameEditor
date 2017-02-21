using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Guard-percentage")]
	public class GuardPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}