using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "visitors-allowed")]
	public class VisitorsAllowed
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}