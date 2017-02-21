using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "time-to-next-blizzard")]
	public class TimeToNextBlizzard
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}