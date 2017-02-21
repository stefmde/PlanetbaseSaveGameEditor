using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "state")]
	public class State
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}