using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "Worker-percentage")]
	public class WorkerPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}