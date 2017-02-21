using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "condition")]
	public class Condition
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}