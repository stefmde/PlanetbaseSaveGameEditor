using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "state")]
	public class State
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}