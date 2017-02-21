using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "pending-visitors")]
	public class PendingVisitors
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}