using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Worker-percentage")]
	public class WorkerPercentage
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}