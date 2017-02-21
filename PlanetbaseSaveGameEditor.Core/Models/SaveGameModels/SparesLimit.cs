using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "Spares-limit")]
	public class SparesLimit
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}