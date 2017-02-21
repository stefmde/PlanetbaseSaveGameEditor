using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "amount")]
	public class ValueAmount
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}