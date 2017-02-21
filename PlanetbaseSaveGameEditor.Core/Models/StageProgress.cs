using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "stage-progress")]
	public class StageProgress
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}