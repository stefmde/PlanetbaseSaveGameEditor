using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "build-progress")]
	public class BuildProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}