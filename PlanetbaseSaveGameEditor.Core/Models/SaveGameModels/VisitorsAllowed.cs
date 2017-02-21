using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "visitors-allowed")]
	public class VisitorsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}